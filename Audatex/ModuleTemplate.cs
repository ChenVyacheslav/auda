using Core;
using dadatacsharp;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using RabbitSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Audatex.AudaHistoryServiceReferences;
using Audatex.UpdateReferences;

namespace Audatex
{
    [Process(Name = "Audatex", Version = 1)]
    public class AudatexProcess : BaseProcess<InputVariables, OutputVariables>
    {
        protected static AudaHistoryServices audaHistoryServices = AudaHistoryServices.Create();
        public override Queues Queue { get; set; } = Queues.TestModule;

        /// <summary>
        /// Ловим ошибки внутри работы модуля
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="channel"></param>
        /// <param name="model"></param>
        /// <param name="ea"></param>
        /// <returns></returns>
        public override bool Exception(Exception ex, Channel channel, object model, BasicDeliverEventArgs ea)
        {
            return false;
        }


        public override Task<bool> Event(Channel channel, object model, BasicDeliverEventArgs ea, InputVariables input, OutputVariables output)
        {
            var idString = Encoding.UTF8.GetString((byte[])ea.BasicProperties.Headers["id"]); // Вытаскиваем инфу в заголовках?
            var id = Guid.Parse(idString);

            //logger.Error("Пишем лог логики модуля");
            //loggerResponse.Error("Пишем лог респонса");

            // loggerResponse.Error($"{JsonConvert.SerializeObject(input)}");


            var data = new Dictionary<string, string>
            {
                { StructureType.LoginId, input.LoginId },
                { StructureType.Password, input.Password},
                { StructureType.VIN, input.VIN}
            };

            var b2bParams = getB2bParameters(data);
            var request = new B2BRequest() { parameter = b2bParams.ToArray() };

            B2BResponse response = null;
            try
            {
                response = audaHistoryServices.History(request);
            }
            catch (WebException we)
            {
                if (false) //TODO: Обработка ошибок (недостаточно данных для реализации)
                {
                    logger.Error($"Error");
                    return Task.FromResult(true);
                }
                else throw we;
            }

            if (response == null || response.text == null)
            {
                logger.Error($"{id} | Некорректный response. {JsonConvert.SerializeObject(response)}");
                return Task.FromResult(true);
            }


            output.Response = response.message;

            // Если требуется повторить задание
            if (false) { return Task.FromResult(false); }

            // Можно создать задачу для другого модуля
            if (false)
            {
                channel.Props.Add("id", Encoding.UTF8.GetBytes(Guid.NewGuid().ToString()));
                channel.Publish(Exchanges.TestExchange, RabbitSettings.TestExchange.Routing.Test);
            }

            return Task.FromResult(true);
        }

        private List<B2BParameter> getB2bParameters(Dictionary<string, string> data)
        {
            var b2bParameters = new List<B2BParameter>();
            foreach (var d in data)
            {
                b2bParameters.Add(new B2BParameter { name = d.Key, value = d.Value });
            }
            return b2bParameters;
        }
    }

    public class InputVariables
    {
        [DisplayName(Name = "Логин")]
        public string LoginId { get; set; }
        [DisplayName(Name = "Пароль")]
        public string Password { get; set; }
        [DisplayName(Name = "VIN")]
        public string VIN { get; set; }
    }

    public class OutputVariables
    {
        //TODO: Распарсить ответ (сейчас его нет, и примера тоже)
        [DisplayName(Name = "Ответ")]
        public object Response { get; set; }
    }

    public static class StructureType
    {
        public static readonly string LoginId = "loginId";
        public static readonly string Password = "password";
        public static readonly string VIN = "VIN";
    }
}

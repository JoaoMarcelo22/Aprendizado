using System;
using System.Globalization;

 namespace Ex015{
     class Program{
         static void Main(string[] args)
         {
             Console.Clear();

            var data = new DateTime(2020, 10, 12, 13, 23, 14);  // Apresenta todos os dados de uma data
            //var data = DateTime.Now;    // Apresenta o horario atual 
            Console.WriteLine(data); 
            Console.WriteLine(data.Year); // salvar o ano
            Console.WriteLine(data.Month);   //salvar mes
            Console.WriteLine(data.Day);     //salvar dia
            Console.WriteLine(data.Hour);    //salvar hora
            Console.WriteLine(data.Minute);  //salvar minuto
            Console.WriteLine(data.Second);  //salvar segundos
            Console.WriteLine(data.DayOfWeek); //salva o dia da semana
            Console.WriteLine((int)data.DayOfWeek); //salvar dia da semana sendo 0 até 6
            Console.WriteLine(data.DayOfYear);    //salvar o dia do ano





         }
         static void Formato()
         {
             Console.clear();

             var data = DateTime.Now;

             var formatada = string.Format("{0:yyyy}", data); //FORMATAÇÃO DE ANO
             var formatada = string.Format("{0:M}", data); //FORMATAÇÃO MÊS
             var formatada = string.Format("{0:d}", data); //FORMATAÇÃO DIA 
             var formatada = string.Format("{0:h}", data); //FORMATAÇÃO HORA
             var formatada = string.Format("{0:m}", data); //FORMATAÇÃO MINUTO
             var formatada = string.Format("{0:s}", data);  //FORMATAÇÃO SEGUNDO
             var formatada = string.Format("{0:z}", data); //FORMATAÇÃO DO FUSO HORARIO
             Console.WriteLine(formatada);
         }
         static void PadroesFormat(){
                Console.Clear();

                var data = DateTime.Now;

                var formatada = string.Format("{0:t}",data); // short time menor 
                var formatada = string.Format("{0:d}",data); // menor data possivel
                var formatada = string.Format("{0:T}",data); // tempo longo
                var formatada = string.Format("{0:D}",data); // Data longa
                var formatada = string.Format("{0:f}",data); // combina data e hora
                var formatada = string.Format("{0:g}",data); // combina os dois da melhor forma
                var formatada = string.Format("{0:r}",data); // com certo padrão
                var formatada = string.Format("{0:R}",data); // mesmo padrão
                var formatada = string.Format("{0:s}",data); //converter para o JSON
                var formatada = string.Format("{0:u}",data); // padrão universal

                Console.WriteLine(formatada);
         }
         static void AdicionandoVal(){
             Console.Clear();

             var data = DateTime.Now;

             data.AddDays(12); // adiciona dias
             data.AddHours(2);  //adiciona horas
             data.AddYears(50); //adiciona anos
             data.AddMonths(1); // adiciona meses

             Console.WriteLine(data);
         }
         static void ComparandoVal(){
             Console.Clear();

            var data = DateTime.Now;
            
            if(data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual"); // comparação apenas da data, já que as horas são diferentes
            }                                 // todas as comparações são usaveis neste caso

             Console.WriteLine(data);
         }
         static void LocaGloba(){
             Console.Clear();

             var br = new CultureInfo("pt-BR");
             var pt = new CultureInfo("pt-PT");
             var en = new CultureInfo("en-US");
             var de = new CultureInfo("de-DE");
             var atual = CultureInfo.CurrentCulture;

             Console.WriteLine(DateTime.Now.ToString("D", atual));

             Console.WriteLine(data);

            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());
            Console.WriteLine("_________");

             var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");       // mudando a data para o UTC da austalia
             Console.Write(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            var horaAtual = TimeZoneInfo.ConvertTimeToUtc(horaAustralia, timezoneAustralia);        // mudando a hora para o UTC da australia
            Console.WriteLine(horaAtual);


            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                 Console.WriteLine(timezone.Id);
                 Console.WriteLine(timezone);
                 Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));            // tranformando a data local para a TIMEZONE
                 Console.WriteLine("_________");
             }

             var brazilTime = TimeZoneInfo.FindSystemTimeZoneById("");


            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);  //APENAS HORA
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);  // HORA, MINUTO E SEGUNDO
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);  //DIA , HORA , MINUTO E SEGUNDO
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100); //DIA, HORA, MINUTO, SEGUNDO E MILISEGUNDO
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0))); //

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));  // QUANDTOS DIAS TEM O ANO
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));  //É FINAL DE SEMANA ??
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());  // ESTAMOS EM HORARIO DE VERAO??
         }
     }
 }
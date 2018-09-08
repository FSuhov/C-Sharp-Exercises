using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team1 = new Team("Гопломахи", "Гопломах (hoplomachus от греческого «οπλομάχος» — «вооружённый боец»)\n — довольно распространенный тип гладиатора. Своим снаряжением имитировал греческих гоплитов.\nСамо слово hoplomachus происходит от греческого ὁπλομάχος («вооруженный боец» или «воин с\nгоплоном»). Доспехи гопломаха состояли из шлема, маленького круглого щита-пармы или большого легионерского щита,\nсделанного из одного листа толстой бронзы (сохранились образцы из Помпеи), стёганных обмоток (fasciae)\nна обеих ногах или высоких поножей (ocreae), доспеха для предплечья-маники (manica)\nна правой руке. Шлем гопломаха имел широкие поля, забрало с решеткой, верховья с плюмажем.\nПо бокам шлема вставляли перья. Вооружен гопломах был копьем-гастой (hasta) и кинжалом-пугио (pugio).");
            Team team2 = new Team("Мирмиллоны", "Фракиец (Thraex, множество — Thraeces) — один из самых распространенных\nтипов гладиаторов. Достоверно, этот тип гладиаторов появился в результате появления в I веке до н. э.\nбольшого количества военнопленных фракийцев. Снаряжение этого типа повторяло национальное фракийское:\nвооруженный он изогнутым кинжалом-сико, доспехи состояли из шлема, стеганных обмоток на обеих ногах,\nвысоких поножей, небольшого прямоугольного сильно выгнутого щита и наруча на правой руке.\nШлем фракийца имел широкие поля, забрало с решеткой и характерного верховья в виде грифона — одного из символов богини мести Немезиды.");
            Team team3 = new Team("Ретиарии", "Ретиарий (retiarius) — один из самых распространенных типов гладиаторов,\nназвание которого буквально значит «боец с сеткой», «сеточник».\nЛегковооруженный тип гладиатора. Доспехи ретиария состоял из наруча-Маника на левой руке (manica) и металлического рюкзака-галера (galerus),\nчто защищал левое плечо и, частично, шею. Дрался ретиарий обнаженным по пояс, низ живота был прикрыт настегновою повязкой — сублигакулумом (subligaculum).\nПоверх повязки крепился пояс (cingulum или balteus). Ноги могли быть защищены матерчатыми обмотками (fasciae).\nВооружение состояло из трезубца (tridens), который также назывался «вилами» (furcina), сетки (rete, retia) и кинжала-пугио (pugio) на поясе.\nПоскольку сетка ретиария была метательным орудием (jaculum), этот тип иногда звали также «якулатор» (iaculator, jaculator), то есть «кидальщик»");

            List<Team> teams = new List<Team>() { team1, team2, team3 };            

            //foreach(Team team in teams)
            //{
            //    Console.WriteLine(team.ToString());
            //}

            Gladiatrix gladiatrix1 = new Gladiatrix("Tanya Daniell", 87, 69, 7.4f);
            Gladiatrix gladiatrix2 = new Gladiatrix("Goldie Blair", 68, 56, 6.5f);
            Gladiatrix gladiatrix3 = new Gladiatrix("Eva Karrera", 91, 80, 5.1f);
            Gladiatrix gladiatrix4 = new Gladiatrix("Cristina Carter", 91, 99, 8.1f);
            Gladiatrix gladiatrix5 = new Gladiatrix("Amber Michaells", 99, 90, 4.5f);
            Gladiatrix gladiatrix6 = new Gladiatrix("Ashlet Renee", 55, 70, 5.8f);
            Gladiatrix gladiatrix7 = new Gladiatrix("Trina Michaels", 49, 59, 4.2f);
            Gladiatrix gladiatrix8 = new Gladiatrix("Alison Tayler", 90, 59, 6.3f);
            Gladiatrix gladiatrix9 = new Gladiatrix("Sasha Monet", 95, 88, 5.9f);
            Gladiatrix gladiatrix10 = new Gladiatrix("Electra Blue", 45, 49, 3.9f);


            List <Gladiatrix> listOfGladiatrixes = new List<Gladiatrix>();
            listOfGladiatrixes.Add(gladiatrix1);
            listOfGladiatrixes.Add(gladiatrix2);
            listOfGladiatrixes.Add(gladiatrix3);
            listOfGladiatrixes.Add(gladiatrix4);
            listOfGladiatrixes.Add(gladiatrix5);
            listOfGladiatrixes.Add(gladiatrix6);
            listOfGladiatrixes.Add(gladiatrix7);
            listOfGladiatrixes.Add(gladiatrix8);
            listOfGladiatrixes.Add(gladiatrix9);
            listOfGladiatrixes.Add(gladiatrix10);

            Console.WriteLine(listOfGladiatrixes[1].ToString());
            Utilities.AssignTeams(listOfGladiatrixes, teams);

            foreach(Gladiatrix girl in listOfGladiatrixes)
            {
                Console.WriteLine(girl.ToString());
            }


            //LINQ ПРИМЕРЫ EXTENSION METHODS
            var girlsInTeam1 = listOfGladiatrixes
                                    .Where(g => g.Team.Name.Equals("Гопломахи"));

            Console.WriteLine("Гопломахи:");
            foreach(var girl in girlsInTeam1) Console.WriteLine(girl.ToString());
            
            var mostVulnarableGirls = listOfGladiatrixes
                                        .Where(g => g.Excitement > 80)
                                        .OrderByDescending(g=>g.Strength);

            Console.WriteLine();
            Console.WriteLine("Most easy to turn on:");
            foreach (var girl in mostVulnarableGirls) Console.WriteLine(girl.ToString());

            Console.WriteLine();
            var mostResistantGirl = listOfGladiatrixes
                                        .Where(g => g.Resistance > 90)
                                        .Select(g => g.Name);

            Console.WriteLine("Names of most resistant girls:");
            foreach (var girl in mostResistantGirl) Console.WriteLine(girl);

            Console.WriteLine();
            Console.WriteLine("Randomly selected gladiatrix");
            var randomGirl = listOfGladiatrixes.Skip(
                        new Random().Next(listOfGladiatrixes.Count - 1))
                        .Take(1);
            foreach (var girl in randomGirl) Console.WriteLine(girl.ToString());

            Console.WriteLine();
            var maxStrength = listOfGladiatrixes.Max(g => g.Strength);
            Console.WriteLine("The maximum strength among this gladiatrixes is:");
            Console.WriteLine(maxStrength);

            //LINQ ПРИМЕРЫ СИНТАКСИСА QUERY OPERATORS
            var girlsInTeam2 = from g in listOfGladiatrixes
                               where g.Team.Name.Equals("Мирмиллоны")
                               orderby g.Strength descending
                               select g;

            Console.WriteLine();
            Console.WriteLine("Мирмиллоны:");
            foreach (var girl in girlsInTeam2) Console.WriteLine(girl.ToString());

            //DYNAMIC
            dynamic boo = teams[1];
            Console.WriteLine(boo.ToString());
            boo = listOfGladiatrixes[2];
            Console.WriteLine(boo.ToString());
        }

        public static class Utilities
        {
            public static void AssignTeams(List<Gladiatrix> girls, List<Team> teams)
            {
                Random rnd = new Random();
                int girlsPerTeam = girls.Count / teams.Count;
                foreach(Team team in teams)
                {
                    int counter = 0;
                    while(counter < girlsPerTeam)
                    {
                        int index = rnd.Next(girls.Count);
                        if(girls[index].Team == null)
                        {
                            girls[index].Team = team;
                            counter++;
                        }
                    }
                }
                var girlWithoutTeam = girls.Find(g => g.Team == null);
                if (girlWithoutTeam != null)
                {
                    girlWithoutTeam.Team = teams[rnd.Next(teams.Count)];
                }
            }
        }
    }
}

using System.Text;
using System.IO;

namespace _3_task
{
    static class SimpleCSVReader
    {
        static private string FormatSyntax (char symbol)
        {
            switch (symbol)
            {
                case '<':
                    return "&lt;";
                case '>':
                    return "&gt;";
                case '&':
                    return "&amp;";
                case '\n':
                    return "<br/>";
                default:
                    return symbol.ToString();
             }
        }
        static public void Reader (FileStream fStreamInput, FileStream fStreamOtput)
        {
            using (StreamReader streamReader = new StreamReader(fStreamInput, Encoding.Unicode))
            {

                using (StreamWriter streamWriter = new StreamWriter(fStreamOtput, Encoding.Unicode))
                {

                    char[] stringInput;

                    streamWriter.WriteLine("<html>\n" +
                        "<head><title>Таблица</title></head>\n" +
                        "<body>\n" +
                        "<table border=\"1\">\n");                                  //Шапка HTML-файла

                    while (!streamReader.EndOfStream)
                    {
                        streamWriter.Write("<tr><td>");                             //Начало строки в таблице
                        stringInput = (streamReader.ReadLine()).ToCharArray();      //Считать строку из файла INPUT и конвертировать ее в массив символов
                        
                        for (int i = 0; i < stringInput.Length; i++)
                        {

                            if (stringInput[i].Equals((char)34))                    //если считанный символ - кавычка
                            {
                                i++;

                                if (i >= stringInput.Length - 1)                    //если сразу за кавычкой следует перенос строки
                                {
                                    streamWriter.Write("<br/>");
                                    stringInput = (streamReader.ReadLine()).ToCharArray();
                                    i = 0;
                                }

                                while (true)
                                {
                                    if (i != stringInput.Length - 1 && (stringInput[i].Equals((char)34) && stringInput[i+1].Equals((char)34))) //Если 2 кавычки подряд
                                    {
                                        streamWriter.Write("\"");
                                        i += 2;
                                    }
                                    else if (stringInput[i].Equals((char)34))       //Если кавычка одна, ВЫХОД из цикла
                                    {
                                        i++;
                                        break;
                                    } 
                                    else if(i >= stringInput.Length - 1)            //Если кавычки не закрылись, но строка кончилась, значит это перенос строки
                                    {
                                        streamWriter.Write("<br/>");                //Внести перенос строки в файл, считать новую строку
                                        stringInput = (streamReader.ReadLine()).ToCharArray();
                                        i = 0;
                                    }
                                    else
                                    {                                               //Считать символ в пределах кавычек и отформатировать его согласно заданным правилам
                                        streamWriter.Write(FormatSyntax(stringInput[i]));
                                        i++;
                                    }
                                }
                            }
                            if (i == stringInput.Length)                            //Если в строке больше нет символов, ВЫХОД
                            {
                                break;
                            }
                            if (stringInput[i].Equals(','))                         //Заменить запятую на теги ячейки   
                            {
                                streamWriter.Write("</td><td>");
                            }
                            else
                            {
                                streamWriter.Write(FormatSyntax(stringInput[i]));   //Считать символ в файл и отформатировать его согласно заданным правилам
                            }

                        }


                        streamWriter.Write("</td></tr>\n");                         //Конец строки таблицы
                    }
                    
                    streamWriter.WriteLine("</table>\n" + "</body>\n" + "</html>\n"); //Конец HTML-файла
                }
            }
        }
    }
}

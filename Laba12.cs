Console.WriteLine("Введите путь к файлу");
StreamReader pach_user = new StreamReader(Console.ReadLine());
StreamWriter progect = new StreamWriter(Directory.GetCurrentDirectory(), false);
progect.Write(pach_user.ReadToEnd);
pach_user.Close();
progect.Close();    
Console.WriteLine("Файл был перезаписан в папку с проектом");

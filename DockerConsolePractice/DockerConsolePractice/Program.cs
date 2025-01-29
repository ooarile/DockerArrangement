namespace DockerConsolePractice
{
    class Program
    {
        static void Main()
        {
            string path = "/lbsemicon"; // Docker 컨테이너 내의 경로
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Directory 생성 : {path}");
            }
            else
            {
                Console.WriteLine($"Directory 삭제 : {path}");
                Directory.Delete(path, true); // true parameter enables recursive deletion
            }

            path = "/lbsemicon/myfolder"; // Docker 컨테이너 내의 경로
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Directory 생성 : {path}");
            }
            else
            {
                Console.WriteLine($"Directory 삭제 : {path}");
                Directory.Delete(path, true); // true parameter enables recursive deletion
            }
        }
    }
}

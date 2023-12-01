namespace PracticeWebApps_LogicLibrary.Managers
{
    public class CodeController
    {
        private int randomCode;
        private Random random;
        public CodeController()
        {
            randomCode = 0;
            random = new Random();
        }
        public int GenerateCode() => randomCode = random.Next(9999);
        public bool IsCodeValid(int code) => randomCode == code;
    }
}
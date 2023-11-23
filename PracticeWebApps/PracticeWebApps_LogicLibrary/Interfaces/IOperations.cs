namespace PracticeWebApps_LogicLibrary.Interfaces
{
    public interface IOperations<T> where T : class
    {
        public T[] LoadObjects();
        public T GetObject(string stringForSearch);
        public int GetObjectId(string stringForSearch);
        public bool CreateObject(T t);
        public bool EditObject(T t, string previousName);
        public bool DeleteObject(T t);
        public bool IsObjectPresent(T t);
    }
}

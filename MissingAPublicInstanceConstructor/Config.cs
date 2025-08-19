namespace MissingAPublicInstanceConstructor
{
    public class Config
    {
        public Config() { }
        public string PropString { get; set; }
        public int PropInt { get; set; }
        public Class1 PropClass1 { get; set; }
        public Class2 PropClass2 { get; set; }
    }
    public class Class1
    {
        public Class1() { }
        public string PropString { get; set; }
        public int PropInt { get; set; }
    }
    public class Class2
    {
        public Class2() { }
        public string PropString { get; set; }
        public int PropInt { get; set; }
    }
}

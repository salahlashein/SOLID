namespace program
{

    public class Program
    {

        static void Main(string[] args)
        {

            Loggers.Logs("stating rate.");

            Loggers.Logs("loading policy.");

            Policy policy = JsonSerializetion.JsonToObj<Policy>(FilePolicySource.GetPolicyFromSource());

            policy.ToString();


        }




    }
}

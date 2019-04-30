using System;

namespace LaunchGALProps
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 2) {
                dynamic objApp;
                dynamic objNamespace;

                objApp = Activator.CreateInstance(Type.GetTypeFromProgID("Outlook.Application"));
                objNamespace = objApp.GetNamespace("MAPI");

                objNamespace.CreateRecipient(args[1]).AddressEntry.Details();
            }
        }
    }
}

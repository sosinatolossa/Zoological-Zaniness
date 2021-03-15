using System;
using System.Collections.Generic;

namespace Zoological_Zaniness
{
    public interface IWalking // we say interface I+Walking, instead of 'class Walking' because this is interface class
    //and this is the parent class, kind of parent interface class
    {
        // we don't need to specify that this method is public because all interface classes are public
        // we're specifying methods here that other classes have define these methods if they're going to use it which Pigeon and Seagull do
        void Run();
        void Walk();
    }
}
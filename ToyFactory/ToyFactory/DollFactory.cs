using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactory
{
    public class DollFactory : IFactory<Doll>
    {
        public Doll MakeElement() => new Doll();
        
    }
}

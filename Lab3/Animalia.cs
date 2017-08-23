using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // класс животные
    public abstract class Animalia
    {
        protected string classis; // класс
        protected string phylum; // тип
        protected bool multicellular; //многоклеточный
        protected bool aerobe; // аэробный // get, set в Млекопитающих
        protected bool dioecious; // двуполый 

        public string Classis
        {
            get
            {
                return classis;
            }
            set
            {
                classis = value;
            }
        }

        public string Phylum
        {
            get
            {
                return phylum;
            }
            set
            {
                phylum = value;
            }
        }

        public bool Multicellular
        {
            get
            {
                return multicellular;
            }
            set
            {
                multicellular = value;
            }
        }

        public bool Aerobe
        {
            get
            {
                return aerobe;
            }
            set
            {
                aerobe = value;
            }
        }

        public bool Dioecious
        {
            get
            {
                return dioecious;
            }

            set
            {
                dioecious = value;
            }
        }

        public virtual bool NeedOxygen()
        {
            return aerobe;
        }

        public bool IsItMulticellular()
        {
            return multicellular;
        }

        public abstract bool IsItDioecious();
    }
}

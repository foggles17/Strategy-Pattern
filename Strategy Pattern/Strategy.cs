using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public abstract class Strategy
    {
        public Form1 myForm;
        public Strategy(Form1 myForm)
        {
            this.myForm = myForm;
        }
        public abstract void enact();
    }
    public class WeakRockStrategy : Strategy
    {
        public WeakRockStrategy(Form1 myForm) : base(myForm) { }

        public override void enact()
        {
            myForm.currentFighter = myForm.rockFighter;
            myForm.attack(false);
        }
    }
    public class StrongRockStrategy : Strategy
    {
        public StrongRockStrategy(Form1 myForm) : base(myForm) { }
        public override void enact()
        {
            myForm.currentFighter = myForm.rockFighter;
            myForm.attack(true);
        }
    }
    public class WeakPaperStrategy : Strategy
    {
        public WeakPaperStrategy(Form1 myForm) : base(myForm) { }
        public override void enact()
        {
            myForm.currentFighter = myForm.paperFighter;
            myForm.attack(false);
        }
    }
    public class StrongPaperStrategy : Strategy
    {
        public StrongPaperStrategy(Form1 myForm) : base(myForm) { }

        public override void enact()
        {
            myForm.currentFighter = myForm.paperFighter;
            myForm.attack(true);
        }
    }
    public class WeakScissorsStrategy : Strategy
    {
        public WeakScissorsStrategy(Form1 myForm) : base(myForm) { }

        public override void enact()
        {
            myForm.currentFighter = myForm.scissorsFighter;
            myForm.attack(false);
        }
    }
    public class StrongScissorsStrategy : Strategy
    {
        public StrongScissorsStrategy(Form1 myForm) : base(myForm) { }

        public override void enact()
        {
            myForm.currentFighter = myForm.scissorsFighter;
            myForm.attack(true);
        }
    }
    public class DoNothingStrategy : Strategy
    {
        public DoNothingStrategy(Form1 myForm) : base(myForm) { }

        public override void enact()
        {
            myForm.doNothing();
        }
    }
}

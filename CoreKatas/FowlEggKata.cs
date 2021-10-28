using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas
{
    public class Goose : IFowl
    {
        public Goose CreateGoose()
        {
            return new Goose();
        }

        public FowlEgg Lay()
        {
            return new FowlEgg(CreateGoose);
        }
    }

    public class Chicken : IFowl
    {
        public Chicken CreateChicken()
        {
            return new Chicken();
        }

        public FowlEgg Lay()
        {
            return new FowlEgg(CreateChicken);
        }
    }

    public class FowlEgg
    {
        private Func<IFowl> CreateBird { get; set; }

        public FowlEgg(Func<IFowl> createBird)
        {
            CreateBird = createBird;
        }

        public IFowl Hatch()
        {
            if (CreateBird == null)
                return null;

            var bird = CreateBird();
            CreateBird = null; //Eggs can only hatch once
            return bird;
        }
    }

    public interface IFowl
    {
        public FowlEgg Lay();
    }
}

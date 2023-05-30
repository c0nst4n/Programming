using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public enum ObjectType
    {
        OBSTACLE,
        CAR
    }
   public abstract class RaceObject
    {
        private string _name;

        private double _position;

        private ObjectType _type;

        private bool can_function;

        private int turns;

        private bool _isEnabled = true;
        public string Name => _name;

        public double Position => _position;

        public ObjectType Type => _type;

        public bool isEnabled => _isEnabled;

        public RaceObject(string name, double position, ObjectType objectType)
        {
            this._name = name;
            this._position = position;
            this._type = objectType;
        }

        public abstract ObjectType GetObjectType();
        
        public abstract bool IsEnabled();

        public void Disable()
        {
            _isEnabled= false;
        }
        public void Disable(int turns)
        {
            for (int i = 0; i < turns; i++)
            {
                _isEnabled= false;
            }

            _isEnabled= true;
        }

        public abstract void Simulate(IRace race);

        public void ModifyPosition(double modyfier) 
        {
            _position += modyfier;
        }
    }
}

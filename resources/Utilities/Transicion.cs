using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Body_Factory_Manager
{
    class Transicion
    {
        /*List<Action> functions = new List<Func<int>>();
        functions.Add(Move);

        foreach (Action func in functions) func();
        */

        private float inicio = 0;
        private float final = 0;
        private float xAbsoluta = 0;
        private float intervalo = 0.1f;

        private float fade(float x)
        {
            const float n1 = 7.5625f;
            const float d1 = 2.75f;

            if (x < 1 / d1)
            {
                return n1 * x * x;
            }
            else if (x < 2 / d1)
            {
                return n1 * (x -= 1.5f / d1) * x + 0.75f;
            }
            else if (x < 2.5 / d1)
            {
                return n1 * (x -= 2.25f / d1) * x + 0.9375f;
            }
            else
            {
                return n1 * (x -= 2.625f / d1) * x + 0.984375f;
            }
        }

        public void Establecer(float inicio, float final, float intervalo = -1f)
        {
            this.inicio = inicio;
            this.final = final;
            Reiniciar();
            if(intervalo > -1) this.intervalo = intervalo;

        }

        public void Reiniciar()
        {
            xAbsoluta = 0;
        }
        public float Avanzar()
        {
            xAbsoluta = Math.Min(xAbsoluta + intervalo, 1f);
            return (int)(inicio + ((final - inicio) * fade(xAbsoluta)));
        }
        
    }
}

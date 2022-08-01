using System;
using System.Collections.Generic;

namespace Body_Factory_Manager
{
    public class Transicion
    {
        /*List<Action> functions = new List<Func<int>>();
        functions.Add(Move);

        foreach (Action func in functions) func();
        */

        public Transicion(int type)
        {
            transicionIndex = type;
        }
        private float inicio = 0;
        private float final = 0;
        private float xAbsoluta = 0;
        private float intervalo = 0.1f;
        TipoTransicion[] Transiciones = new TipoTransicion[] {new Bounce(), new Fade1()};
        int transicionIndex = 0;
        private float bounce(float x)
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
            if (intervalo > -1) this.intervalo = intervalo;

        }

        public float Obtener()
        {
            return (int)(inicio + ((final - inicio) * Transiciones[transicionIndex].calculo(xAbsoluta)));

        }

        public void Reiniciar()
        {
            xAbsoluta = 0;
        }
        public float Avanzar()
        {
            xAbsoluta = Math.Min(xAbsoluta + intervalo, 1f);
            return (int)(inicio + ((final - inicio) * Transiciones[transicionIndex].calculo(xAbsoluta)));
        }

    }

    interface TipoTransicion
    {
        float calculo(float x);
    }

    public class Bounce : TipoTransicion
    {
        public float calculo(float x)
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
    }

    public class Fade1 : TipoTransicion
    {
        public float calculo(float x)
        {
            return (float) Math.Sin((x * Math.PI) / 2);
        }
    }
}

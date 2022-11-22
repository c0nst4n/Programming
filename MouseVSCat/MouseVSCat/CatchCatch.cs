using DAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseVSCat
{
    internal class CatchCatch : DAM.IGameDelegate
    {
        character cat;
        character rat;
         float blue = 0.4f;
         float x = -0.2f;
         float y = -0.2f;
        double time = 0.0;
        


        /*  public static List<character> CreateCharacter()
          {
              List<character> list = new List<character>();
              character cat = new character();
              cat.x = 0.0f;
              cat.y = 2.0f;
              cat.width = 30.0f;
              cat.height = 10.0f;
              cat.r = 1.0f;
              cat.g = 1.0f;
              cat.b = 1.0f;
              cat.a = 1.0f;
              cat.type = CharacterType.CAT;
              list.Add(cat);


              character rat = new character();
              rat.x = 3.0f;
              rat.y = 5.0f;
              rat.width = 25.0f;
              rat.height = 25.0f;
              rat.r = 0.0f;
              rat.g = 0.0f;
              rat.b = 0.0f;
              rat.a = 1.0f;
              rat.type = CharacterType.MOUSE;
              list.Add(rat);
              return list;
          }*/
        public void OnDraw(IAssetManager manager, IWindow window,ICanvas canvas)
        {
           

            float ar = ((float)window.Width) / ((float)window.Height);

            canvas.SetCamera(-1 ,-1, 1, 1, true);

            canvas.Clear(0.0f, 0.0f, blue, 1.0f);
            time += (1 / 60);
            double a = Math.Sin(time);
            double b = (a + 1) / 2;




            cat.Render(canvas);
            rat.Render(canvas);
          // if (collision.checkCollision(cat.x, rat.x, cat.y, rat.y, cat.width, rat.width, cat.height, rat.height))
            //    canvas.Clear(0.0f, 0.0f, 0.0f, 1.0f);

        }

        public void OnKeyboard(IAssetManager manager, IWindow window, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Right))
                this.rat.x += 0.001f;
            if (keyboard.IsKeyDown(Keys.Left))
                this.rat.x -= 0.001f;
            if (keyboard.IsKeyDown(Keys.Up))
                this.rat.y += 0.001f;
            if (keyboard.IsKeyDown(Keys.Down))
                this.rat.y -= 0.001f;

            if (this.cat.x > (1 - cat.width /2))
                this.cat.x = (1 - cat.width / 2);
            if (this.cat.x < -1.0f)
                this.cat.x = -1.0f;

            if (this.cat.y > (1 - cat.width / 2))
                this.cat.y = (1 - cat.width / 2);
            if (this.cat.y < (-1 + cat.width / 2))
                this.cat.y = (-1 + cat.width / 2);


            if (keyboard.IsKeyDown(Keys.D))
                this.cat.x += 0.001f;
            if (keyboard.IsKeyDown(Keys.A))
                this.cat.x -= 0.001f;
            if (keyboard.IsKeyDown(Keys.W))
                this.cat.y += 0.001f;
            if (keyboard.IsKeyDown(Keys.S))
                this.cat.y -= 0.001f;


            if (this.rat.x > (1 - rat.width / 2))
                this.rat.x = (1 - rat.width / 2);
            if (this.rat.x < (-1 + rat.width / 2))
                this.rat.x = (-1 + rat.width / 2);


            if (this.rat.y > (1 - rat.width / 2))
                this.rat.y = (1 - rat.width / 2);
            if (this.rat.y < (-1 + rat.width / 2))
                this.rat.y = (-1 + rat.width / 2);

            if (keyboard.IsKeyDown(Keys.Escape))
            {
                window.Close();
            }
        }

        public void OnLoad(IAssetManager manager, IWindow window)
        {
            
            cat = new character();

            cat.image = manager.LoadImage("resources/GATO.png");
            float catar = (float)cat.image.Width / (float)cat.image.Height;
            cat.x = 0.0f;
            cat.y = 0.0f;
            cat.width = 0.5f;
            cat.height = cat.width / catar;
            cat.r = 1.0f;
            cat.g = 1.0f;
            cat.b = 1.0f;
            cat.a = 1.0f;
            cat.type = CharacterType.CAT;


            rat = new character();
            rat.image = manager.LoadImage("resources/raton.png");
            float ratar = (float)rat.image.Width / (float)rat.image.Height;
            rat.x = 0.0f;
            rat.y = 0.0f;
            rat.width = 0.5f;
            rat.height = rat.width / ratar;
            rat.r = 1.0f;
            rat.g = 1.0f;
            rat.b = 1.0f;
            rat.a = 1.0f;
            rat.type = CharacterType.MOUSE;
           

            window.ToggleFullscreen();
        }

        public void OnUnload(IAssetManager manager, IWindow window)
        {
            
        }
    }
}

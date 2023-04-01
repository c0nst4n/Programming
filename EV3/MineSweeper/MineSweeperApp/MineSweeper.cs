using MineSweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using UDK;


namespace MineSweeperApp
{
    internal class MineSweeper : IGameDelegate
    {
        IBoard board = new ListBoard();
        UDK.IFontFace? font;
        public bool firstClick = true;
        int cellCountWidth = 10;
        int cellCountHeight = 10;

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {

            var rect = new rect2d_f64(0.0, 0.0, cellCountWidth, cellCountHeight);

            canvas.Clear(new rgba_f64(0.2, 0.2, 0.2, 1.0));
            canvas.Camera.SetRect(rect, true);

            canvas.FillShader.SetColor(new rgba_f64(0.4, 0.4, 0.4, 1.0));
            canvas.Transform.SetTranslation(0, 0);
            canvas.DrawRectangle(rect);

            paintCells(canvas, cellCountWidth, cellCountHeight);
            
        }

        private void paintCells(ICanvas canvas,int cellCountWidth, int cellCountHeigth) 
        {
            for (int y = 0; y < cellCountHeigth; y++) 
            {
                for(int x = 0; x < cellCountWidth; x++)
                {
                    var cellRect = new rect2d_f64(0.1, 0.1, 0.8, 0.8);

                    canvas.FillShader.SetColor(new rgba_f64(0.5, 0.5, 0.5, 1.0));
                    canvas.Transform.SetTranslation(x, y);
                    canvas.DrawRectangle(cellRect);
                    
                    if (board.IsCellOpen(x, y))
                    {
                        if (!board.IsBombAt(x, y))
                        {
                            canvas.FillShader.SetColor(new rgba_f64(1, 0, 0, 1.0));
                            canvas.Transform.SetTranslation(x, y);
                            canvas.DrawRectangle(cellRect);
                            canvas.Transform.Translate(0.3, 0.5);
                            canvas.FillShader.SetColor(new rgba_f64(1, 1, 1, 1));
                            canvas.DrawText(new vec2d_f64(0, 0), board.GetBombProximity(x, y).ToString(), font, new TextMode() { height = 0.2, bottomCoords = false });
                        }
                        else if (board.IsBombAt(x, y))
                        {
                            canvas.FillShader.SetColor(new rgba_f64(1, 0, 1, 1.0));
                            canvas.Transform.SetTranslation(x, y);
                            canvas.DrawRectangle(cellRect);
                            canvas.Transform.Translate(0.3, 0.5);
                            canvas.FillShader.SetColor(new rgba_f64(1, 1, 1, 1));
                            canvas.DrawText(new vec2d_f64(0, 0), "B", font, new TextMode() { height = 0.2, bottomCoords = false });
                        }

                    }
                    if (board.IsFlagAt(x, y))
                    {
                        canvas.FillShader.SetColor(new rgba_f64(1, 0.5, 0.5, 1.0));
                        canvas.Transform.SetTranslation(x, y);
                        canvas.DrawRectangle(cellRect);
                        canvas.Transform.Translate(0.3, 0.5);
                        canvas.FillShader.SetColor(new rgba_f64(1, 1, 1, 1));
                        canvas.DrawText(new vec2d_f64(0, 0), "F", font, new TextMode() { height = 0.2, bottomCoords = false });
                    }

                }

            }
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            var pos = gameEvent.coordinateConversor.ViewToWorld(mouse.X, mouse.Y);
            int X = (int)pos.x;
            int Y = (int)pos.y;
            if (mouse.IsPressed(MouseButton.Left))
            {
                if (pos.x < 0 || pos.y < 0 || pos.x > cellCountWidth || pos.y > cellCountHeight)
                {
                    return;
                }
                //Console.WriteLine();
                int casillaX = (int)pos.x;
                int casillaY = (int)pos.y;
                casillaY = (int)(board.GetHeight() - mouse.Y - 1);

                OnClick(gameEvent, mouse);

                if (pos.x < 0 || pos.y < 0 || pos.x > cellCountWidth || pos.y > cellCountHeight)
                {
                    return;
                }

                if (!board.IsCellOpen(X, Y))
                    board.OpenCell(X, Y);

            }

            if (mouse.IsPressed(MouseButton.Right))
            {
                if (pos.x < 0 || pos.y < 0 || pos.x > cellCountWidth || pos.y > cellCountHeight)
                {
                    return;
                }
                //Console.WriteLine();
                int casillaX = (int)pos.x;
                int casillaY = (int)pos.y;
                casillaY = (int)(board.GetHeight() - mouse.Y - 1);

                if (!board.IsCellOpen(X,Y) && !board.IsFlagAt(X, Y))
                {
                    OnClick(gameEvent, mouse);
                    board.PutFlagAt(X, Y);
                }
                else
                {
                    OnClick(gameEvent, mouse);
                    board.DeleteFlagAt(X, Y);
                    board.CloseCell(X, Y);
                }

            }

        }

        public void OnClick(GameDelegateEvent gameEvent, IMouse mouse)
        {
            var pos = gameEvent.coordinateConversor.ViewToWorld(mouse.X, mouse.Y);
            int X = (int)pos.x;
            int Y = (int)pos.y;

            if (firstClick)
            {
                board.Init(X, Y, 5);
                firstClick = false;
            }

            

        }
        public void OnLoad(GameDelegateEvent gameEvent)
        {
            board.CreateBoard(cellCountWidth, cellCountHeight);
            font = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/ArialCE.ttf"))?.CreateFontFace(80.0);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
            
        }

        public void OpenCellsArround(int x,int y)
        {

        }
    }
}

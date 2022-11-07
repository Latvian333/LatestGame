using SharpGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Objects
{

    internal class EnemyList
    {
        public ArrayList array = new ArrayList();
        SoundPlayer soundPlayer = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + @"\Objects\Sounds\Death.wav");
        public EnemyList()
        {

        }

        public void Add(Enemy enemy)
        {
            array.Add(enemy);
        }

        public void Delete(Enemy enemy)
        {
            array.Remove(enemy);
        }

        public void Clear()
        {
            array.Clear();
        }

        public int Count()
        {
            int x = array.Count;
            return x;
        }

        public int checkifreachedplayer(OpenGL gl, int counter)
        {
            int damage = 0;
            for (int i = 0; i < array.Count; i++)
            {
                Enemy testenemy = (Enemy)array[i];
                if (testenemy.reachedplayer == true && counter <= 10)
                {
                    array.RemoveAt(i);
                    Enemy newEnemy = new Enemy();
                    array.Add(newEnemy);
                    damage = damage + 1;
                    counter = counter + 1;
                }else if (testenemy.boxcount == 0 && counter <= 10)
                {
                    soundPlayer.Play();
                    array.RemoveAt(i);
                    Enemy newEnemy = new Enemy();
                    array.Add(newEnemy);
                    counter = counter + 1;
                }
            }
            return damage;


        }

        public int checkifpressed(KeyPressEventArgs e)
        {
            int points = 0;
            foreach (Enemy enemy in array)
            {
                points = points + enemy.checkboxes(e);
            }
            return points;
        }

        public void render(OpenGL gl)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Enemy enemy = (Enemy)array[i];
                enemy.initializetexture(gl);
                enemy.renderEnemy(gl);
            }
        }

        public Enemy first()
        {
            Enemy first = (Enemy)array[0];
            return first;
        }
    }
}

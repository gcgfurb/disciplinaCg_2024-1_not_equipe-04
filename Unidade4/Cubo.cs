//https://github.com/mono/opentk/blob/main/Source/Examples/Shapes/Old/Cube.cs

#define CG_Debug
using CG_Biblioteca;
using OpenTK.Mathematics;
using System.Drawing;

namespace gcgcg
{
  internal class Cubo : Objeto
  {
    Ponto4D[] vertices;
 

    public Cubo(Objeto paiRef, ref char _rotulo) :
      this(paiRef, ref _rotulo, new Ponto4D(-0.5, -0.5), new Ponto4D(0.5, 0.5)){}

    public Cubo(Objeto paiRef, ref char _rotulo, Ponto4D ptoInfEsq, Ponto4D ptoSupDir) : base(paiRef, ref _rotulo) 
    {

      float[] _vertices = {
        -0.3f, -0.3f,  0.3f,
         0.3f, -0.3f,  0.3f,
         0.3f,  0.3f,  0.3f,
        -0.3f,  0.3f,  0.3f,
        -0.3f, -0.3f, -0.3f,
         0.3f, -0.3f, -0.3f,
         0.3f,  0.3f, -0.3f,
        -0.3f,  0.3f, -0.3f
      };
      
      vertices = new Ponto4D[]
      {
        new Ponto4D(-0.3, -0.3,  0.3),
        new Ponto4D( 0.3, -0.3,  0.3),
        new Ponto4D( 0.3,  0.3,  0.3),
        new Ponto4D(-0.3,  0.3,  0.3),
        new Ponto4D(-0.3, -0.3, -0.3),
        new Ponto4D( 0.3, -0.3, -0.3),
        new Ponto4D( 0.3,  0.3, -0.3),
        new Ponto4D(-0.3,  0.3, -0.3)
      };
      
      base.PontosAdicionar(vertices[0]);
      base.PontosAdicionar(vertices[1]);
      base.PontosAdicionar(vertices[2]);
      base.PontosAdicionar(vertices[3]);

      base.PontosAdicionar(vertices[3]);
      base.PontosAdicionar(vertices[2]);
      base.PontosAdicionar(vertices[6]);
      base.PontosAdicionar(vertices[7]);

      base.PontosAdicionar(vertices[7]);
      base.PontosAdicionar(vertices[6]);
      base.PontosAdicionar(vertices[5]);
      base.PontosAdicionar(vertices[4]);

      base.PontosAdicionar(vertices[4]);
      base.PontosAdicionar(vertices[7]);
      base.PontosAdicionar(vertices[3]);
      base.PontosAdicionar(vertices[0]);

      base.PontosAdicionar(vertices[0]);
      base.PontosAdicionar(vertices[4]);
      base.PontosAdicionar(vertices[5]);
      base.PontosAdicionar(vertices[1]);
      
      base.PontosAdicionar(vertices[1]);
      base.PontosAdicionar(vertices[2]);
      base.PontosAdicionar(vertices[6]);
      base.PontosAdicionar(vertices[5]);
      Atualizar();
    }
    public Ponto4D[] getVertices(){
      return this.vertices;
    }
    public static int ColorToRgba32(Color c)
    {
      return (int)((c.A << 24) | (c.B << 16) | (c.G << 8) | c.R);
    }

    private void Atualizar()
    {

      base.ObjetoAtualizar();
    }

#if CG_Debug
    public override string ToString()
    {
      string retorno;
      retorno = "__ Objeto Cubo _ Tipo: " + PrimitivaTipo + " _ Tamanho: " + PrimitivaTamanho + "\n";
      retorno += base.ImprimeToString();
      return (retorno);
    }
#endif

  }
}

using System.ComponentModel.DataAnnotations;

#if UNITY_2018_3_OR_NEWER
using UnityEngine;
#endif

namespace Graphene.SharedModels.ModelView
{
    public class CharactersModelView
    {
        [Required] public int Id;
        [Required] public string Name;

        public float[] Color;


#if UNITY_2018_3_OR_NEWER
        public Color GetColor()
        {
            return new Color(Color[0], Color[1], Color[2], Color[3]);
        }
#endif
    }
}
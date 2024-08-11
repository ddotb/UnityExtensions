using UnityEngine;

namespace ddotb
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Get a random color from the neon color group.
        /// </summary>
        public static Color GetRandomNeonColor(this Color color)
        {
            float h = Random.value;
            float s = 1.0f;
            float v = 0.5f;

            return Color.HSVToRGB(h, s, v);
        }

        /// <summary>
        /// Gets a random color from the pastel color group.
        /// </summary>
        public static Color GetRandomPastelColor(this Color color)
        {
            float h = Random.value;
            float s = 0.5f;
            float v = 0.5f;

            return Color.HSVToRGB(h, s, v);
        }
        
        /// <summary>
        /// Gets a random color with a specific hue.
        /// </summary>
        public static Color GetRandomColorWithHue(this Color color, float hue)
        {
            float s = Random.value;
            float v = Random.value;
            
            return Color.HSVToRGB(hue, s, v); 
        }
        
        /// <summary>
        /// Gets a random color with a specific saturation.
        /// </summary>
        public static Color GetRandomColorWithSaturation(this Color color, float saturation)
        {
            float h = Random.value;
            float v = Random.value;
            
            return Color.HSVToRGB(h, saturation, v); 
        }
        
        /// <summary>
        /// Gets a random color with a specific value.
        /// </summary>
        public static Color GetRandomColorWithValue(this Color color, float value)
        {
            float h = Random.value;
            float s = Random.value;
            
            return Color.HSVToRGB(h, s, value); 
        }

        /// <summary>
        /// Gets a purely random color with optional random alpha.
        /// </summary>
        public static Color GetRandomColor(this Color color, bool randomAlpha)
        {
            float r = Random.value;
            float g = Random.value;
            float b = Random.value;

            float a = randomAlpha ? Random.value : 1.0f;
            
            return new Color(r, g, b, a);
        }

        /// <summary>
        /// Get a purely random color but allow specification of the alpha.
        /// </summary>
        public static Color GetRandomColor(this Color color, float alpha)
        {
            Color newColor = new Color().GetRandomColor(false);
            newColor.a = alpha;

            return newColor;
        }
    }
}

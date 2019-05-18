using UnityEngine;
using UnityEngine.UI;

namespace CustomPackageA
{
    public class LabelTest : MonoBehaviour
    {
        [SerializeField]
        private UnityEngine.UI.Text _text;

        void Start()
        {
#if USING_TEXTMESHPRO_2_0_1
            _text.text = "TextMeshPro 2.0.1";
#elif USING_TEXTMESHPRO_2_0_0
            _text.text = "TextMeshPro 2.0.0";
#else
            _text.text = "uGUI Only";
#endif
        }
    }
}
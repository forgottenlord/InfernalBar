using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace InfernalBar
{
    public class Bar : MonoBehaviour
    {
        [SerializeField]
        public Transform potionPos;
        [SerializeField]
        public List<Potion> potionPrefabs = new List<Potion>();
        [SerializeField]
        private PotionType currentType;
        public Potion CreatePotion(PotionType potionType)
        {
            Potion p = potionPrefabs.Find(p => p.type == potionType);
            if (p == null)
            {
                log.text += "Такого нет в меню!";
                return null;
            }
            log.text += p.Title;
            log.text += System.Environment.NewLine;
            p = Instantiate(p);
            p.transform.position = potionPos.position;
            return p;
        }

        private void Start()
        {
            for (int n = 0; n < buttons.Count; n++)
            {
                int t = n;
                buttons[n].onClick.AddListener(()=> Switch(t));
            }
            confirmButton.onClick.AddListener(() => CreatePotion(currentType));
        }
        private void Switch(int n)
        {
            currentType = ((PotionType)Mathf.Pow(2, n));
        }
        [SerializeField]
        private List<Button> buttons = new List<Button>();
        [SerializeField]
        private Text log;
        [SerializeField]
        private Button confirmButton;
    }
}
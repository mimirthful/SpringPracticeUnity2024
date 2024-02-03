using UnityEngine;

namespace Mobiiliesimerkki 
{
    /// <summary>
    /// This script changes the color of the sprite.
    /// </summary>
    public class ColorChanger : MonoBehaviour
    {
        // Luokan jäsenmuuttujat
        private SpriteRenderer _spriteRenderer;
        //Taulukko värejä varten.
        [SerializeField] 
        private Color[] colors;

        /// <summary>
        /// Start-metodia kutsutaan, kun peliobjekti luodaan (juuri ennen ensimmäistä Update-kutsua).
        
        /// </summary>
        private void Start()
        { 
            // Haetaan viittaus SpriteRenderer-komponenttiin.
            //GetComponent palauttaa tässä GameObjectissa olevan SpriteRenderer-komponentin.
            // Jos GameObjectissa ei ole SpriteRenderer komponenttia, palautetaan null.
            _spriteRenderer = GetComponent<SpriteRenderer>();
            // Asettaa listan ensimmäisen värin aloitusväriksi.
            _spriteRenderer.color = colors[0];
        }

        // Update is called once per frame. Pelilogiikka toteutetaan pääasiallisesti Update-metodin
        // avulla. Update-metodia kutsutaan aina ennen kuin piirretään uusi frame. Esimerkiksi olion
        //liikkuminen voidaan toteuttaa Updatessa.
        private void Update()
        {
            // Vaihdetaan väriä sekunnin välein, tähän voidaan käyttää jakojäännöstä (% eli modulo operaattori)
            //jakojäännös palauttaa jakolaskun jäljelle jäävän osan.
            // esimerkiksi 5%2 =1 koska 5/2 =2 ja 1 jää jäljelle.
            
            //Asetetaan uusi väri, väri valitaan taulukosta käyttämällä jakojäännöstä time.time muuttujassa
            //jakojäännös palauttaa arvot 0, 1 ja 2.
            int index = (int)(Time.time % colors.Length);
            _spriteRenderer.color = colors[index];
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmenu : MonoBehaviour {

    // Fungsi untuk tombol exit / keluar game
    public void quit() {
        Application.Quit();
    }

    // Fungsi untuk tombol play / pindah scene
    public void play(string scene_name) {
        Application.LoadLevel(scene_name); 
        // Catatan: Jika menggunakan Unity versi baru, bisa juga memakai:
        // UnityEngine.SceneManagement.SceneManager.LoadScene(scene_name);
    }

    // Fungsi untuk tombol kontak email
    public void mailto(string mail) {
        Application.OpenURL("mailto:" + mail);
    }

    // Fungsi untuk mengatur volume suara melalui PlayerPrefs
    public void sound_volume(float volume) {
        PlayerPrefs.SetFloat("volume", volume);
    }
}
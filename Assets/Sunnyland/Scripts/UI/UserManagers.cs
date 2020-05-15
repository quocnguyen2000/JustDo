using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserManagers : MonoBehaviour {
    public GameObject userEntry;
    public Transform userList;
    private List<UserModel> users = new List<UserModel> ();

    string URL = "http://localhost/Unity3D/list.php";

    void Start () {
        GetUser ();
    }

    // Update is called once per frame
    void Update () {

    }

    public void GetUser () {
        StartCoroutine (conectServer ());
    }

    IEnumerator conectServer () {
        users.Clear ();

        WWWForm wf = new WWWForm ();

        WWW w = new WWW (URL, wf);

        yield return w;

        string data = w.text; 

        Debug.Log (data);

        string[] a = new String[] {};

        a = data.Split (',');

        for (int i = 0; i < (a.Length) - 1; i++) {
            string dataUser = a[i];
            string[] b = new String[] { };
            b = dataUser.Split ('-');
            users.Add (new UserModel (b[0], b[1], b[2], b[3]));
        }
     
        this.ShowUser ();

    }

    public void ShowUser () {
        for (int i = 0; i < users.Count; i++) {
            if (i <= users.Count - 1) {

                GameObject g = (GameObject) Instantiate (userEntry);

                g.transform.SetParent (this.transform);

                UserModel tmpUser = users[i];

                g.transform.Find ("ID").GetComponent<Text> ().text = tmpUser.id;
                g.transform.Find ("Name").GetComponent<Text> ().text = tmpUser.username;
                g.transform.Find ("Location").GetComponent<Text> ().text = tmpUser.located;
                g.transform.Find ("Password").GetComponent<Text> ().text = tmpUser.password; 

            }
        }
    }
}
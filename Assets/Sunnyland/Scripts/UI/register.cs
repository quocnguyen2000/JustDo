using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class register : MonoBehaviour
{

    public InputField id, username, located, password;
    public Button btndangky;

    string loginPHP = "http://localhost/Unity3D/register.php";
    // Update is called once per frame
    void Update()
    {

    }

    void Start()
    {
    }
    public void Login()
    {
        StartCoroutine(conectServer());
    }

    IEnumerator conectServer()
    {

        WWWForm wf = new WWWForm();

        wf.AddField("id", id.text);  //user.text trong unity
        wf.AddField("username", username.text);  // pass.text trong unity
        wf.AddField("located", located.text);  //user.text trong unity
        wf.AddField("password", password.text);  // pass.text trong unity
                                               //CHAY TOI DAY  user.text gan gia tri nguoi dung da nhap cho bien username
                                               // pass.text gan gia tri nguoi dung da nhap cho bien password

        //username = "abc";
        //password = "123456";

        Debug.Log(id.text);
        Debug.Log(username.text);

        WWW w = new WWW(loginPHP, wf);

        yield return w;



        print("Dang ky thanh cong");


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class login : MonoBehaviour
{

    public InputField user, pass;
    public Button btnLogin;

    string loginPHP = "http://localhost/Unity3D/dangNhap.php";
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

        wf.AddField("username", user.text);  //user.text trong unity
        wf.AddField("password", pass.text);  // pass.text trong unity

        //CHAY TOI DAY  user.text gan gia tri nguoi dung da nhap cho bien username
        // pass.text gan gia tri nguoi dung da nhap cho bien password

        //username = "abc";
        //password = "123456";

        Debug.Log(user.text);
        Debug.Log(pass.text);

        WWW w = new WWW(loginPHP, wf);

        yield return w;


        if (w.text == "success")
        {

            print("Dang nhap thanh cong");

            //SceneManager.LoadScene("abc"); 

        }
        else
        {


            print("Dang nhap khong thanh cong");

        }
    }
}

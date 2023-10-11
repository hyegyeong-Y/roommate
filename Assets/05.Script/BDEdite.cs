using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

public class BDEdite : MonoBehaviour
{
    private MySqlConnection connection;
    private string server = "127.0.0.1";
    private string database = "BBS";
    private string username = "root";
    private string password = "6065";

    public InputField nameInputField;
    public InputField ageInputField;
    public InputField genderInputField;
    public InputField weightInputField;
    public InputField heightInputField;
    public Button homeButton;



    // Start is called before the first frame update
    private void Start()
    {
        string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};charset=utf8";
        connection = new MySqlConnection(connectionString);
        try
        {
            connection.Open();


            // 변경 후 연결을 끊습니다.

            homeButton.onClick.AddListener(GoToHome);
        }
        catch (MySqlException ex)
        {
            Debug.LogError("Error: " + ex.Message);
        }
    }

    private void GoToHome()
    {

        string newName = nameInputField.text;
        string newAge = ageInputField.text;
        string newGender = genderInputField.text;
        string newWeight = weightInputField.text;
        string newHeight = heightInputField.text;

        bool hasUpdates = false;

        if (string.IsNullOrEmpty(newName))
        {
            newName = GetCurrentField("userName");
        }
        else
        {
            hasUpdates = true;
        }

        if (string.IsNullOrEmpty(newAge))
        {
            newAge = GetCurrentField("userAge");
        }
        else
        {
            hasUpdates = true;
        }

        if (string.IsNullOrEmpty(newGender))
        {
            newGender = GetCurrentField("userGender");
        }
        else
        {
            hasUpdates = true;
        }

        if (string.IsNullOrEmpty(newWeight))
        {
            newWeight = GetCurrentField("userWeight");
        }
        else
        {
            hasUpdates = true;
        }

        if (string.IsNullOrEmpty(newHeight))
        {
            newHeight = GetCurrentField("userHeight");
        }
        else
        {
            hasUpdates = true;
        }

        if (!hasUpdates)
        {
            SceneManager.LoadScene("Page4");
        }

        try
        {
           

            // 데이터베이스 업데이트
            string updateQuery = "UPDATE user SET userName = @newName, userAge = @newAge, userGender = @newGender, userWeight = @newWeight, userHeight = @newHeight";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@newAge", newAge);
            command.Parameters.AddWithValue("@newGender", newGender);
            command.Parameters.AddWithValue("@newWeight", newWeight);
            command.Parameters.AddWithValue("@newHeight", newHeight);

            command.ExecuteNonQuery();

            connection.Close();
            SceneManager.LoadScene("Page4");
        }
        catch (MySqlException ex)
        {
            connection.Close();
            SceneManager.LoadScene("Page4");
            Debug.LogError("Error: " + ex.Message);
        }
      
    }
    private string GetCurrentField(string fieldName)
    {
        string query = $"SELECT {fieldName} FROM user LIMIT 1";
        MySqlCommand command = new MySqlCommand(query, connection);
        string currentValue = command.ExecuteScalar()?.ToString();
        return currentValue;
    }

}
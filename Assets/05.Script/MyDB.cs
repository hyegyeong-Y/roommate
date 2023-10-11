using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

public class MyDB : MonoBehaviour
{
    private MySqlConnection connection;
    private string server = "127.0.0.1";
    private string database = "BBS";
    private string username = "root";
    private string password = "6065";
    public Text outputText;

    void Start()
    {
        string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        connection = new MySqlConnection(connectionString);

        try
        {
            // 데이터베이스 연결
            connection.Open();
            Debug.Log("Connected to MySQL database!");

            // 쿼리 실행
            string query = "SELECT * FROM user;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            // 결과 출력
            while (dataReader.Read())
            {
                // 모든 컬럼 출력
                for (int i = 1; i < dataReader.FieldCount; i++)
                {
                    string columnName = dataReader.GetName(i);
                    string columnValue = dataReader.GetValue(i).ToString();
                    outputText.text += columnName + ": " + columnValue + "\n";
                }
            }

            // 데이터 리더 닫기
            dataReader.Close();

            // 연결 닫기
            connection.Close();
        }
        catch (MySqlException ex)
        {
            Debug.LogError("Error: " + ex.Message);
        }
    }

}
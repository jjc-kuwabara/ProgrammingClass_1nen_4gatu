using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai_3 : MonoBehaviour
{
    void Start()
    {

    }

    // �T�C�R����U��֐�.
    public void RollSaikoro()
    {
        // �����iInteger�j�̒l���i�[���邽�߂́Aint�^�̕ϐ���錾����.
        // �ϐ��̖��O�́ArandomSaikoro_Player�ł���.
        int randomSaikoro_Player;
        // �ϐ��̖��O�́ArandomSaikoro_Enemy�ł���.
        int randomSaikoro_Enemy;

        // 1����6�܂ł̒l���o���������g���āA�T�C�R���̖ڂ��w�肷��.
        randomSaikoro_Player = Random.Range(1, 6 + 1);
        randomSaikoro_Enemy = Random.Range(1, 6 + 1);

        // �T�C�R���̖ڂ̒l���w�肵�āA�摜��ς���.
        JJC.SetPlayerSaikoro(randomSaikoro_Player);
        JJC.SetEnemySaikoro(randomSaikoro_Enemy);

        // �m�F�̂��߁A�������\������.
        Debug.Log("���Ȃ���" + randomSaikoro_Player.ToString() + "�̖ڂ��o����.���C�o����" + randomSaikoro_Enemy.ToString() + "�̖ڂ��o����");

        string[] resultStrings = new string[3];
        resultStrings[0] = "���Ȃ��̏���";
        resultStrings[1] = "���Ȃ��̕���";
        resultStrings[2] = "��������";

        // ���Ȃ��̖ڂ̕����傫��������A���Ȃ��̏����ƕ\�����Ă�������.
        // ���Ȃ��̖ڂ̕���������������A���Ȃ��̕����ƕ\�����Ă�������.
        // �����ڂ�������A���������ƕ\�����Ă�������.
        JJC.KickPopUpMsgBox("������𖢐ݒ�");
    }
}

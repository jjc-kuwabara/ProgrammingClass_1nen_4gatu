using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai_5 : MonoBehaviour
{
    void Start()
    {
        // ������iString�j���i�[���邽�߂́Astring�^�̕ϐ���錾����.
        // �^���̌���[]��t����ƁA�u�z��v��錾���Ă��邱�ƂɂȂ�܂�.
        // �z��́A�l���i�[���邽�߂̕ϐ����A�������݂��Ă���ꍇ�Ɋ��p���܂�.
        string[] talentName;

        // �z���錾�����ꍇ�A�K���A���̗v�f���������z��Ȃ̂��A�錾����K�v������܂�.
        talentName = new string[4];

        // ���ꂼ��̗v�f�ɑ΂��āA�l���i�[���邱�Ƃ��ł��܂�.
        talentName[0] = "�e�c�؂���";
        talentName[1] = "�s�m�΃t���A";
        talentName[2] = "����m�G��";
        talentName[3] = "����}����";

        // ������iInteger�j���i�[���邽�߂́Aint�^�̕ϐ���錾����.
        // �^���̌���[]��t����ƁA�u�z��v��錾���Ă��邱�ƂɂȂ�܂�.
        // �z��́A�l���i�[���邽�߂̕ϐ����A�������݂��Ă���ꍇ�Ɋ��p���܂�.
        int[] talentSaikoro;
        talentSaikoro = new int[4];

        // 1����6�܂ł̒l���o���������g���āA�T�C�R���̖ڂ��w�肷��.
        talentSaikoro[0] = Random.Range(1, 6 + 1);
        talentSaikoro[1] = Random.Range(1, 6 + 1);
        talentSaikoro[2] = Random.Range(1, 6 + 1);
        talentSaikoro[3] = Random.Range(1, 6 + 1);


        // �J��Ԃ�������p���邱�ƂŁA�z��̊e�v�f�ɑ΂��ăA�N�Z�X�o���܂�.
        Debug.Log("�z�����C�u�R�����̊F����̃T�C�R���̖ڂ͎��̒ʂ�ł�.");
        for (int i = 0; i < 4; i++)
        {
            Debug.Log(talentName[i] + "����̃T�C�R���̖ڂ�" + talentSaikoro[i].ToString());
        }

        ///////////////////////////////// �ۑ� //////////////////////////////////////////////////
        // �ł��T�C�R���̖ڂ��傫���l�A�P���̖��O��\�����Ă�������.

        // �ł��傫���T�C�R���̖ڂ�ۑ�����.
        int maxSaikoroValue = 0;
        // �ł��T�C�R���̖ڂ��傫�������^�����g��ID��ۑ�����.
        int maxSaikoroTalentId = 0;
        for (int i = 0; i < 4; i++)
        {
            // if����p���Ĕ�����s���Ă�������.
        }

        Debug.Log("�o�ڂ���ԑ傫�������l��" + talentName[maxSaikoroTalentId] + "����ŁA���̖ڂ�" + talentSaikoro[maxSaikoroTalentId] + "�ł�.");
    }
}

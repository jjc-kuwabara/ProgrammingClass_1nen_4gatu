using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai_4 : MonoBehaviour
{
    void Start()
    {
        // ������iString�j���i�[���邽�߂́Astring�^�̕ϐ���錾����.
        // �^���̌���[]��t����ƁA�u�z��v��錾���Ă��邱�ƂɂȂ�܂�.
        // �z��́A�l���i�[���邽�߂̕ϐ����A�������݂��Ă���ꍇ�Ɋ��p���܂�.
        string[] legendName;

        // �z���錾�����ꍇ�A�K���A���̗v�f���������z��Ȃ̂��A�錾����K�v������܂�.
        legendName = new string[6];

        // ���ꂼ��̗v�f�ɑ΂��āA�l���i�[���邱�Ƃ��ł��܂�.
        legendName[0] = "�u���b�h�n�E���h";
        legendName[1] = "�W�u�����^��";
        legendName[2] = "���C�t���C��";
        legendName[3] = "�p�X�t�@�C���_�[";
        legendName[4] = "���C�X";
        legendName[5] = "�o���K���[��";

        // �J��Ԃ�������p���邱�ƂŁA�z��̊e�v�f�ɑ΂��ăA�N�Z�X�o���܂�.
        Debug.Log("�ŏ�����g�p�\�ȃ��W�F���h�͎��̒ʂ�ł�.");
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(legendName[i]);
        }

        ///////////////////////////////// �ۑ� //////////////////////////////////////////////////
        // Apex Legends�̃��W�F���h�A����23���̖��O��\�����Ă�������.

        string[] allLegendName;

        allLegendName = new string[1];

        allLegendName[0] = "���ݒ�";


        // �J��Ԃ�������p���邱�ƂŁA�z��̊e�v�f�ɑ΂��ăA�N�Z�X�o���܂�.
        Debug.Log("�S�Ẵ`�����s�I���͎��̒ʂ�ł�.");
        for (int i = 0; i < 1; i++)
        {
            Debug.Log(allLegendName[i]);
        }
    }

}

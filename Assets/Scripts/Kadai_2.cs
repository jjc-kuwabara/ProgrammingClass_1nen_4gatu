using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kadai_2 : MonoBehaviour
{
    void Start()
    {
        // �T�C�R����U��֐����Ăяo��.
        RollSaikoro();
    }

    // �T�C�R����U��֐�.
    public void RollSaikoro()
    {
        // �����iInteger�j�̒l���i�[���邽�߂́Aint�^�̕ϐ���錾����.
        // �ϐ��̖��O�́ArandomSaikoro�ł���.
        int randomSaikoro;

        // randomSaikoro�Ƃ����ϐ��ɁA�l���i�[����.
        // 1����6�܂ł̒l���o���������g���āA�T�C�R���̖ڂ��w�肷��.
        randomSaikoro = Random.Range(1, 6 + 1);

        // �T�C�R���̖ڂ̒l���w�肵�āA�摜��ς���.
        JJC.SetSaikoro(randomSaikoro);

        // �m�F�̂��߁A�������\������.
        Debug.Log(randomSaikoro.ToString() + "�̖ڂ��o��.");

        // ��.
        if ( randomSaikoro > 4 )
        {
            Debug.Log("randomSaikoro��4���傫���I");
        }

        ///////////////////////////////// �ۑ� //////////////////////////////////////////////////
        // �ȉ��̂悤��if�����g���āA�T�C�R���̖ڂ�3�ȉ��̎��A���ʂȕ\�����s���Ă�������.
        // ������́A"�i�_�u���N�H�[�e�[�V�����FShift + 2�œ��͂ł��܂��j�őO������ނ��ƂŁA������ł���A�ƃv���O�������F�����܂�.
        /*

        if( ������ ){
            Debug.Log(" �\�������������� ");
        }

         */

        // �������̏�����.
        // randomSaikoro == 1   randomSaikoro�ϐ��̒l���A1�ł���ꍇ�A�^�itrue�j�ƂȂ�.
        // randomSaikoro < 1    randomSaikoro�ϐ��̒l���A1�����ł���ꍇ�A�^�itrue�j�ƂȂ�.
        // randomSaikoro <= 1   randomSaikoro�ϐ��̒l���A1�ȉ��ł���ꍇ�A�^�itrue�j�ƂȂ�.
        // randomSaikoro > 1    randomSaikoro�ϐ��̒l���A1���傫���ł���ꍇ�A�^�itrue�j�ƂȂ�.
        // randomSaikoro >= 1   randomSaikoro�ϐ��̒l���A1�ȏ�ł���ꍇ�A�^�itrue�j�ƂȂ�.
    }
}

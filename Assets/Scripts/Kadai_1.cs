// �����́A�v���O�����̃\�[�X�R�[�h���L�����邽�߂́A.cs�t�@�C���ł��Bcs�́AC-Sharp�iC#�j�̈Ӗ��ł�.
// ����cs�t�@�C���ɁA�v���O���~���O����C#�̕��@�ɉ������������ł����ނ��ƂŁA�v���O�������Ӑ}�ʂ�ɓ����܂�.
// �u//�v���L�������ꏊ����A���́A���s����܂ŁA�R�����g�Ƃ��Ĉ����܂�.
// �R�����g�́A�\�[�X�R�[�h�Ɖ��߂��ꂸ�A��������܂�.

/*
 �@���̂悤�ɋL�����邱�ƂŁA1�s���ł͂Ȃ��A�����s�̃R�����g����邱�Ƃ��o���܂�.
 */

// ���̉��̕����Ausing�Ə����Ă���̂́A�v���O���~���O����C#��A�Q�[���G���W��Unity���񋟂��Ă���A�l�X�ȋ@�\���g�������ł��A�Ƃ��肢�����Ă��܂�.
// �uSystem�v�Ƃ����g�g�݂̒��ɑ��݂���A�uCollections�v�Ƃ����g�g�݂̒��ɂ��鏈����S���g�������ł��B�Ƃ��肢�����Ă��܂�.
// �ȉ����l�ɁA�uGeneric�v�Ƃ����g�g�݂̒��̏������g�������A�uUnityEngine�v�Ƃ����g�g�݂̒��̏������g�������A�uUI�v�Ƃ����g�g�݂̒��̏������g�������A�Ƃ��肢�����Ă��܂�.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��������A�v���O�����̋�̓I�ȏ������L�ڂ��܂�.
// �����ł́A�uKadai1�v�Ƃ������O�̃N���X�iClass�j�̐錾���s���Ă��܂�.
// �N���X�́A�p�����[�^��A�v�Z�������A������₷���[�߂Ă������߂̔��ł�.
// Unity�̌��܂�Ƃ��āA�K���A�\�[�X�R�[�h�̃t�@�C�����ƈ�v�������O�̃N���X��錾����K�v������܂�.
public class Kadai_1 : MonoBehaviour
{
    // Start�֐��́A�v���O�������N�����Ă���A1�񂾂��Ăяo�������ł�.
    void Start()
    {
        timerSinceGamePlay = 0.0f;
        Debug.Log("Start�֐����Ăт܂���. �Q�[���N������o�߂������Ԃ�" + timerSinceGamePlay.ToString() + "�b�ł�.");
    }

    // Update�֐��́A�v���O�������N�����āAStart�֐��̎��s������������ɁA���t���[���Ăяo�������ł�.
    void Update()
    {
        timerSinceGamePlay = timerSinceGamePlay + Time.deltaTime; // �O��̋N��������o�߂����b�������Z���Ă��܂�.
        Debug.Log(Time.frameCount.ToString() + "�t���[���ڂ�Update�֐����Ăт܂���.  �Q�[���N������o�߂������Ԃ�" + timerSinceGamePlay.ToString() + "�b�ł�.");
    }

    float timerSinceGamePlay; // �Q�[���N������o�߂������ԁi�b���j.
}

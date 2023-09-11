using System;
using UnityEngine;
using FastCampus.QuestSystem;

public enum QuestsubpointType
{ 
    DestroyEnemy,
    GetItem
}

//public enum QuestSubpointStatus
//{
//    Uncompleted,
//    Completed,    
//}

// ����Ʈ ��ǥ. �ϳ��� ����Ʈ�� ���� ����Ʈ ��ǥ�� ���� �� �ִ�.
[Serializable]
public class QuestSubpoint
{
    //public QuestSubpointStatus status; // ���� ��ǥ�� �����Ȳ
    public QuestsubpointType type; // ��ǥ Ÿ��

    public int targetID; // ��ǥ ���(������, ��)

    public bool isCompleted => completedCount >= targetCount;

    [Min(0)]
    public int targetCount; // óġ�ϰų� ����ؾ��ϴ� ��/������ ����.

    [Min(0)]
    public int completedCount; // óġ�ϰų� ����� ��/������ ����.
}

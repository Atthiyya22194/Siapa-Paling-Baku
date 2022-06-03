using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Problem
{
    public string kataPertama;           // kata pertama dalam problem
    public string kataKedua;          // kata kedua dalam problem
    public PemisahKata operation;    // garis pemisah kedua kata
    public float[] answers;             // array dari semua kemungkinan jawaban

    [Range(0, 1)]
    public int correctTube;             // index dari tube yang benar
}

public enum PemisahKata
{
    Pemisah
}
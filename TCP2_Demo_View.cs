using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B58 RID: 2904
[Token(Token = "0x2000791")]
public class TCP2_Demo_View : MonoBehaviour
{
	// Token: 0x06004AB6 RID: 19126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E95")]
	[Address(RVA = "0x1FBC830", Offset = "0x1FBC931", VA = "0x1FBC830")]
	private void Awake()
	{
	}

	// Token: 0x06004AB7 RID: 19127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E96")]
	[Address(RVA = "0x1FBC8A0", Offset = "0x1FBC9A1", VA = "0x1FBC8A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004AB8 RID: 19128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E97")]
	[Address(RVA = "0x1FBC8D0", Offset = "0x1FBC9D1", VA = "0x1FBC8D0")]
	private void Update()
	{
	}

	// Token: 0x06004AB9 RID: 19129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E98")]
	[Address(RVA = "0x1FBD0C0", Offset = "0x1FBD1C1", VA = "0x1FBD0C0")]
	public void ResetView()
	{
	}

	// Token: 0x06004ABA RID: 19130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E99")]
	[Address(RVA = "0x1FBD130", Offset = "0x1FBD231", VA = "0x1FBD130")]
	public TCP2_Demo_View()
	{
	}

	// Token: 0x0400AB31 RID: 43825
	[Token(Token = "0x400812A")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174CE0", Offset = "0x174DE1")]
	public float OrbitStrg;

	// Token: 0x0400AB32 RID: 43826
	[Token(Token = "0x400812B")]
	[FieldOffset(Offset = "0x1C")]
	public float OrbitClamp;

	// Token: 0x0400AB33 RID: 43827
	[Token(Token = "0x400812C")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174D20", Offset = "0x174E21")]
	public float PanStrg;

	// Token: 0x0400AB34 RID: 43828
	[Token(Token = "0x400812D")]
	[FieldOffset(Offset = "0x24")]
	public float PanClamp;

	// Token: 0x0400AB35 RID: 43829
	[Token(Token = "0x400812E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174D60", Offset = "0x174E61")]
	public float ZoomStrg;

	// Token: 0x0400AB36 RID: 43830
	[Token(Token = "0x400812F")]
	[FieldOffset(Offset = "0x2C")]
	public float ZoomClamp;

	// Token: 0x0400AB37 RID: 43831
	[Token(Token = "0x4008130")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174DA0", Offset = "0x174EA1")]
	public float Decceleration;

	// Token: 0x0400AB38 RID: 43832
	[Token(Token = "0x4008131")]
	[FieldOffset(Offset = "0x38")]
	public Transform CharacterTransform;

	// Token: 0x0400AB39 RID: 43833
	[Token(Token = "0x4008132")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 mouseDelta;

	// Token: 0x0400AB3A RID: 43834
	[Token(Token = "0x4008133")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 orbitAcceleration;

	// Token: 0x0400AB3B RID: 43835
	[Token(Token = "0x4008134")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 panAcceleration;

	// Token: 0x0400AB3C RID: 43836
	[Token(Token = "0x4008135")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 moveAcceleration;

	// Token: 0x0400AB3D RID: 43837
	[Token(Token = "0x4008136")]
	[FieldOffset(Offset = "0x70")]
	private float zoomAcceleration;

	// Token: 0x0400AB3E RID: 43838
	[Token(Token = "0x4008137")]
	private const float XMax = 60f;

	// Token: 0x0400AB3F RID: 43839
	[Token(Token = "0x4008138")]
	private const float XMin = 300f;

	// Token: 0x0400AB40 RID: 43840
	[Token(Token = "0x4008139")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 mResetCamPos;

	// Token: 0x0400AB41 RID: 43841
	[Token(Token = "0x400813A")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 mResetCamRot;

	// Token: 0x0400AB42 RID: 43842
	[Token(Token = "0x400813B")]
	[FieldOffset(Offset = "0x8C")]
	private bool mMouseDown;
}

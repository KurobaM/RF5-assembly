using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B96 RID: 2966
[Token(Token = "0x20007B4")]
public class RopeMaxTensionHandler : MonoBehaviour
{
	// Token: 0x06004C12 RID: 19474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FC5")]
	[Address(RVA = "0x27DB4E0", Offset = "0x27DB5E1", VA = "0x27DB4E0")]
	private void Start()
	{
	}

	// Token: 0x06004C13 RID: 19475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FC6")]
	[Address(RVA = "0x27DB550", Offset = "0x27DB651", VA = "0x27DB550")]
	private void LateUpdate()
	{
	}

	// Token: 0x06004C14 RID: 19476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FC7")]
	[Address(RVA = "0x27DBF50", Offset = "0x27DC051", VA = "0x27DBF50")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06004C15 RID: 19477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FC8")]
	[Address(RVA = "0x27DBAD0", Offset = "0x27DBBD1", VA = "0x27DBAD0")]
	private void FixHaywire()
	{
	}

	// Token: 0x06004C16 RID: 19478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FC9")]
	[Address(RVA = "0x27DBF70", Offset = "0x27DC071", VA = "0x27DBF70")]
	public RopeMaxTensionHandler()
	{
	}

	// Token: 0x0400AD10 RID: 44304
	[Token(Token = "0x400828E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _lengthThreshold;

	// Token: 0x0400AD11 RID: 44305
	[Token(Token = "0x400828F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string _maxTensionStartCallMethod;

	// Token: 0x0400AD12 RID: 44306
	[Token(Token = "0x4008290")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string _maxTensionEndCallMethod;

	// Token: 0x0400AD13 RID: 44307
	[Token(Token = "0x4008291")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string _maxTensionContinueCallMethod;

	// Token: 0x0400AD14 RID: 44308
	[Token(Token = "0x4008292")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public GameObject _eventCallGameObject;

	// Token: 0x0400AD15 RID: 44309
	[Token(Token = "0x4008293")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public bool _fixHaywire;

	// Token: 0x0400AD16 RID: 44310
	[Token(Token = "0x4008294")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	public bool _makeEndDynamicOnMaxTension;

	// Token: 0x0400AD17 RID: 44311
	[Token(Token = "0x4008295")]
	[FieldOffset(Offset = "0x48")]
	private UltimateRope _rope;

	// Token: 0x0400AD18 RID: 44312
	[Token(Token = "0x4008296")]
	[FieldOffset(Offset = "0x50")]
	private bool _started;

	// Token: 0x0400AD19 RID: 44313
	[Token(Token = "0x4008297")]
	[FieldOffset(Offset = "0x51")]
	private bool _dynamicEnd;
}

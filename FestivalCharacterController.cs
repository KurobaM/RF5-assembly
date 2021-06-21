using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000228 RID: 552
[Token(Token = "0x20001BD")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x145900", Offset = "0x145A01")]
public class FestivalCharacterController : HumanController
{
	// Token: 0x17000271 RID: 625
	// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00006120 File Offset: 0x00004320
	[Token(Token = "0x17000251")]
	public float InputMoveSensitivity
	{
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x1F7E990", Offset = "0x1F7EA91", VA = "0x1F7E990")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00006138 File Offset: 0x00004338
	[Token(Token = "0x17000252")]
	private float WalkSpeedRate
	{
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x1F7E9A0", Offset = "0x1F7EAA1", VA = "0x1F7E9A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00006150 File Offset: 0x00004350
	// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000253")]
	public FestivalCharacterController.MoveWay NextMoveWay
	{
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x1F7EA10", Offset = "0x1F7EB11", VA = "0x1F7EA10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB50", Offset = "0x19BC51")]
		get
		{
			return FestivalCharacterController.MoveWay.None;
		}
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x1F7EA20", Offset = "0x1F7EB21", VA = "0x1F7EA20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB60", Offset = "0x19BC61")]
		set
		{
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00006168 File Offset: 0x00004368
	// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000254")]
	public Vector3 NextDir
	{
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x1F7EA30", Offset = "0x1F7EB31", VA = "0x1F7EA30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB70", Offset = "0x19BC71")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x1F7EA40", Offset = "0x1F7EB41", VA = "0x1F7EA40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB80", Offset = "0x19BC81")]
		private set
		{
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00006180 File Offset: 0x00004380
	[Token(Token = "0x17000255")]
	public float SnowmanCameraFollowSpeed
	{
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x1F7EA50", Offset = "0x1F7EB51", VA = "0x1F7EA50")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00006198 File Offset: 0x00004398
	[Token(Token = "0x17000256")]
	public float SnowmanCameraRotateSpeed
	{
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x1F7EA60", Offset = "0x1F7EB61", VA = "0x1F7EA60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x06000CBB RID: 3259 RVA: 0x000061B0 File Offset: 0x000043B0
	// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000257")]
	public float SnowmanCurrentMoveRate
	{
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x1F7EA70", Offset = "0x1F7EB71", VA = "0x1F7EA70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB90", Offset = "0x19BC91")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x1F7EA80", Offset = "0x1F7EB81", VA = "0x1F7EA80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BBA0", Offset = "0x19BCA1")]
		private set
		{
		}
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x1F7EA90", Offset = "0x1F7EB91", VA = "0x1F7EA90", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x1F7EAA0", Offset = "0x1F7EBA1", VA = "0x1F7EAA0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x1F7EB60", Offset = "0x1F7EC61", VA = "0x1F7EB60", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x1F7EB70", Offset = "0x1F7EC71", VA = "0x1F7EB70", Slot = "41")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x1F7FA90", Offset = "0x1F7FB91", VA = "0x1F7FA90")]
	public void OnEquipEffect()
	{
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x1F7FB60", Offset = "0x1F7FC61", VA = "0x1F7FB60", Slot = "92")]
	public override void Avoid()
	{
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x000061C8 File Offset: 0x000043C8
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x1F80160", Offset = "0x1F80261", VA = "0x1F80160", Slot = "48")]
	public override bool InputMove(Vector3 _vector)
	{
		return default(bool);
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x1F7EDC0", Offset = "0x1F7EEC1", VA = "0x1F7EDC0")]
	private void UpdateBeansowingMovement()
	{
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x1F7F1E0", Offset = "0x1F7F2E1", VA = "0x1F7F1E0")]
	private void UpdateBaffamoMovement()
	{
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x1F7F600", Offset = "0x1F7F701", VA = "0x1F7F600")]
	private void UpdateSnowmanMovement()
	{
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x000061E0 File Offset: 0x000043E0
	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x1F80230", Offset = "0x1F80331", VA = "0x1F80230")]
	private float GetSnowmanMoveSpeed()
	{
		return 0f;
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x1F803B0", Offset = "0x1F804B1", VA = "0x1F803B0")]
	public void SetupComponent()
	{
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x1F800A0", Offset = "0x1F801A1", VA = "0x1F800A0")]
	public void PlayMotion(string _name, [Optional] float? _repeat_time)
	{
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x1F804C0", Offset = "0x1F805C1", VA = "0x1F804C0")]
	public void PlayRollingVoice()
	{
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x1F80600", Offset = "0x1F80701", VA = "0x1F80600", Slot = "17")]
	public override void OnSwitchActorBase(bool _on)
	{
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x1F80680", Offset = "0x1F80781", VA = "0x1F80680")]
	public FestivalCharacterController()
	{
	}

	// Token: 0x04000781 RID: 1921
	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15DC20", Offset = "0x15DD21")]
	private float inputMoveSensitivity;

	// Token: 0x04000782 RID: 1922
	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private float currentMoveSpeed;

	// Token: 0x04000783 RID: 1923
	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DC60", Offset = "0x15DD61")]
	private FestivalCharacterController.MoveWay <NextMoveWay>k__BackingField;

	// Token: 0x04000784 RID: 1924
	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DC70", Offset = "0x15DD71")]
	private Vector3 <NextDir>k__BackingField;

	// Token: 0x04000785 RID: 1925
	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	[SerializeField]
	private float beanSowingPlayerMoveMaxSpeed;

	// Token: 0x04000786 RID: 1926
	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	[SerializeField]
	private float beanSowingPlayerAcceleration;

	// Token: 0x04000787 RID: 1927
	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[SerializeField]
	private float beanSowingPlayerDeceleration;

	// Token: 0x04000788 RID: 1928
	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	[SerializeField]
	private float beanSowingSmoothRotation;

	// Token: 0x04000789 RID: 1929
	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	[SerializeField]
	private float snowmanPlayerMoveMaxSpeed;

	// Token: 0x0400078A RID: 1930
	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	[SerializeField]
	private float snowmanPlayerAcceleration;

	// Token: 0x0400078B RID: 1931
	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	[SerializeField]
	private float snowmanPlayerDeceleration;

	// Token: 0x0400078C RID: 1932
	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	[SerializeField]
	private float snowmanPlayerSmoothRotation;

	// Token: 0x0400078D RID: 1933
	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	[SerializeField]
	private float snowmanCameraFollowSpeed;

	// Token: 0x0400078E RID: 1934
	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
	[SerializeField]
	private float snowmanCameraRotateSpeed;

	// Token: 0x0400078F RID: 1935
	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DD20", Offset = "0x15DE21")]
	private float <SnowmanCurrentMoveRate>k__BackingField;

	// Token: 0x04000790 RID: 1936
	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	[SerializeField]
	private float baffamoPlayerMoveMaxSpeed;

	// Token: 0x04000791 RID: 1937
	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	[SerializeField]
	private float baffamoPlayerAcceleration;

	// Token: 0x04000792 RID: 1938
	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	[SerializeField]
	private float baffamoPlayerDeceleration;

	// Token: 0x04000793 RID: 1939
	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	[SerializeField]
	private float baffamoPlayerSmoothRotation;

	// Token: 0x04000794 RID: 1940
	[Token(Token = "0x400062A")]
	private const float AVOID_FORCE = 10f;

	// Token: 0x04000795 RID: 1941
	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private readonly Dictionary<Gender, List<SoundID>> ROLLING_VOICE;

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private Gender playerGender;

	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000FF4")]
	public enum Action
	{
		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4018DDE")]
		AVOID,
		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4018DDF")]
		Length
	}

	// Token: 0x0200022A RID: 554
	[Token(Token = "0x2000FF5")]
	public enum MoveWay
	{
		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x4018DE1")]
		None,
		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x4018DE2")]
		Walk,
		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x4018DE3")]
		Run
	}
}

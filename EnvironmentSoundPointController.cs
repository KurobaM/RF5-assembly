using System;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;

// Token: 0x0200087E RID: 2174
[Token(Token = "0x20005A2")]
[Serializable]
public class EnvironmentSoundPointController : SEController
{
	// Token: 0x170007FB RID: 2043
	// (get) Token: 0x06003957 RID: 14679 RVA: 0x00013DA0 File Offset: 0x00011FA0
	// (set) Token: 0x06003958 RID: 14680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000640")]
	private float Interval
	{
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x22B6480", Offset = "0x22B6581", VA = "0x22B6480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E10", Offset = "0x1A5F11")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x22B6490", Offset = "0x22B6591", VA = "0x22B6490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E20", Offset = "0x1A5F21")]
		set
		{
		}
	}

	// Token: 0x06003959 RID: 14681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FDD")]
	[Address(RVA = "0x22B64A0", Offset = "0x22B65A1", VA = "0x22B64A0", Slot = "6")]
	protected override void Awake()
	{
	}

	// Token: 0x0600395A RID: 14682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FDE")]
	[Address(RVA = "0x22B6530", Offset = "0x22B6631", VA = "0x22B6530")]
	protected void Start()
	{
	}

	// Token: 0x0600395B RID: 14683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FDF")]
	[Address(RVA = "0x22B6600", Offset = "0x22B6701", VA = "0x22B6600", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600395C RID: 14684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FE0")]
	[Address(RVA = "0x22B6690", Offset = "0x22B6791", VA = "0x22B6690", Slot = "5")]
	protected override AudioSource ReadyAudioSourceComponent()
	{
		return null;
	}

	// Token: 0x0600395D RID: 14685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FE1")]
	[Address(RVA = "0x22B66E0", Offset = "0x22B67E1", VA = "0x22B66E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600395E RID: 14686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FE2")]
	[Address(RVA = "0x22B6790", Offset = "0x22B6891", VA = "0x22B6790")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x0600395F RID: 14687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FE3")]
	[Address(RVA = "0x22B6830", Offset = "0x22B6931", VA = "0x22B6830", Slot = "13")]
	protected override void SetupBeforePlayByDataTable()
	{
	}

	// Token: 0x06003960 RID: 14688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FE4")]
	[Address(RVA = "0x22B6960", Offset = "0x22B6A61", VA = "0x22B6960", Slot = "20")]
	protected override void Done_Enter()
	{
	}

	// Token: 0x06003961 RID: 14689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x22B69A0", Offset = "0x22B6AA1", VA = "0x22B69A0", Slot = "21")]
	protected virtual void Done_Update()
	{
	}

	// Token: 0x06003962 RID: 14690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x22B6A40", Offset = "0x22B6B41", VA = "0x22B6A40")]
	public EnvironmentSoundPointController()
	{
	}

	// Token: 0x04007CA9 RID: 31913
	[Token(Token = "0x40070BC")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private string SoundIDString;

	// Token: 0x04007CAA RID: 31914
	[Token(Token = "0x40070BD")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private SoundID SerializeSoundID;

	// Token: 0x04007CAB RID: 31915
	[Token(Token = "0x40070BE")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private float m_FadeTime;

	// Token: 0x04007CAC RID: 31916
	[Token(Token = "0x40070BF")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float IntervalMin;

	// Token: 0x04007CAD RID: 31917
	[Token(Token = "0x40070C0")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private float IntervalMax;

	// Token: 0x04007CAE RID: 31918
	[Token(Token = "0x40070C1")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E190", Offset = "0x16E291")]
	private float <Interval>k__BackingField;

	// Token: 0x04007CAF RID: 31919
	[Token(Token = "0x40070C2")]
	[FieldOffset(Offset = "0x9C")]
	private bool InsidePlayer;

	// Token: 0x04007CB0 RID: 31920
	[Token(Token = "0x40070C3")]
	[FieldOffset(Offset = "0xA0")]
	private SphereCollider SphereCollider;

	// Token: 0x04007CB1 RID: 31921
	[Token(Token = "0x40070C4")]
	[FieldOffset(Offset = "0xA8")]
	private bool IsActive;

	// Token: 0x04007CB2 RID: 31922
	[Token(Token = "0x40070C5")]
	[FieldOffset(Offset = "0xAC")]
	private float DoneTime;
}

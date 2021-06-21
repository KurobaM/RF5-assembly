using System;
using System.Collections.Generic;
using Field;
using Il2CppDummyDll;
using RF5_Sound;

// Token: 0x0200087D RID: 2173
[Token(Token = "0x20005A1")]
public class EnvironmentSoundManager : SingletonMonoBehaviour<EnvironmentSoundManager>
{
	// Token: 0x170007F8 RID: 2040
	// (get) Token: 0x0600394A RID: 14666 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600394B RID: 14667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700063D")]
	public Stack<EnvironmentSoundController> ControllerPool
	{
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x22B4C40", Offset = "0x22B4D41", VA = "0x22B4C40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5DB0", Offset = "0x1A5EB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x22B4C50", Offset = "0x22B4D51", VA = "0x22B4C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5DC0", Offset = "0x1A5EC1")]
		private set
		{
		}
	}

	// Token: 0x170007F9 RID: 2041
	// (get) Token: 0x0600394C RID: 14668 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600394D RID: 14669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700063E")]
	public Dictionary<SoundID, EnvironmentSoundController> PlayingControllerDic
	{
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x22B4C60", Offset = "0x22B4D61", VA = "0x22B4C60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5DD0", Offset = "0x1A5ED1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x22B4C70", Offset = "0x22B4D71", VA = "0x22B4C70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5DE0", Offset = "0x1A5EE1")]
		private set
		{
		}
	}

	// Token: 0x170007FA RID: 2042
	// (get) Token: 0x0600394E RID: 14670 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600394F RID: 14671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700063F")]
	public HashSet<EnvironmentSoundPointController> Playing3DSound
	{
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x22B4C80", Offset = "0x22B4D81", VA = "0x22B4C80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5DF0", Offset = "0x1A5EF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x22B4C90", Offset = "0x22B4D91", VA = "0x22B4C90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5E00", Offset = "0x1A5F01")]
		private set
		{
		}
	}

	// Token: 0x06003950 RID: 14672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FD4")]
	[Address(RVA = "0x22B4CA0", Offset = "0x22B4DA1", VA = "0x22B4CA0")]
	public void RemoveAllAreaSound()
	{
	}

	// Token: 0x06003951 RID: 14673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FD5")]
	[Address(RVA = "0x22B4E90", Offset = "0x22B4F91", VA = "0x22B4E90")]
	private void Start()
	{
	}

	// Token: 0x06003952 RID: 14674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FD6")]
	[Address(RVA = "0x22B4FF0", Offset = "0x22B50F1", VA = "0x22B4FF0")]
	private void OnChangeScene()
	{
	}

	// Token: 0x06003953 RID: 14675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FD7")]
	[Address(RVA = "0x22B50B0", Offset = "0x22B51B1", VA = "0x22B50B0")]
	public void Play(EnvironmentSoundType type, FieldSceneId sceneId)
	{
	}

	// Token: 0x06003954 RID: 14676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FD8")]
	[Address(RVA = "0x22B5A60", Offset = "0x22B5B61", VA = "0x22B5A60")]
	private void Update()
	{
	}

	// Token: 0x06003955 RID: 14677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FD9")]
	[Address(RVA = "0x22B6250", Offset = "0x22B6351", VA = "0x22B6250")]
	private void EnvironmentVolumeUpdate()
	{
	}

	// Token: 0x06003956 RID: 14678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FDA")]
	[Address(RVA = "0x22B6350", Offset = "0x22B6451", VA = "0x22B6350")]
	public EnvironmentSoundManager()
	{
	}

	// Token: 0x04007C9F RID: 31903
	[Token(Token = "0x40070B2")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E070", Offset = "0x16E171")]
	private Stack<EnvironmentSoundController> <ControllerPool>k__BackingField;

	// Token: 0x04007CA0 RID: 31904
	[Token(Token = "0x40070B3")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E080", Offset = "0x16E181")]
	private Dictionary<SoundID, EnvironmentSoundController> <PlayingControllerDic>k__BackingField;

	// Token: 0x04007CA1 RID: 31905
	[Token(Token = "0x40070B4")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E090", Offset = "0x16E191")]
	private HashSet<EnvironmentSoundPointController> <Playing3DSound>k__BackingField;

	// Token: 0x04007CA2 RID: 31906
	[Token(Token = "0x40070B5")]
	private const int InitialNum = 4;

	// Token: 0x04007CA3 RID: 31907
	[Token(Token = "0x40070B6")]
	[FieldOffset(Offset = "0x30")]
	private bool DonePaused;

	// Token: 0x04007CA4 RID: 31908
	[Token(Token = "0x40070B7")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16E0A0", Offset = "0x16E1A1")]
	private List<ValueTuple<SoundID, EnvironmentSoundController>> RemoveList;

	// Token: 0x04007CA5 RID: 31909
	[Token(Token = "0x40070B8")]
	private const float VOLUME_UP_TARGET = 1f;

	// Token: 0x04007CA6 RID: 31910
	[Token(Token = "0x40070B9")]
	private const float VOLUME_DOWN_TARGET = 0.7f;

	// Token: 0x04007CA7 RID: 31911
	[Token(Token = "0x40070BA")]
	[FieldOffset(Offset = "0x40")]
	public float EnvironmentVolume;

	// Token: 0x04007CA8 RID: 31912
	[Token(Token = "0x40070BB")]
	[FieldOffset(Offset = "0x44")]
	private bool IsEnvironmentVolumeDown;
}

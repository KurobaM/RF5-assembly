using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x0200027D RID: 637
[Token(Token = "0x20001F9")]
public class FootStepsManager : SingletonMonoBehaviour<FootStepsManager>
{
	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00007350 File Offset: 0x00005550
	[Token(Token = "0x170002B8")]
	public bool IsLoading
	{
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x1ECE8B0", Offset = "0x1ECE9B1", VA = "0x1ECE8B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00007368 File Offset: 0x00005568
	// (set) Token: 0x06000FEC RID: 4076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002B9")]
	private int LoadCounter
	{
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x1ECE8C0", Offset = "0x1ECE9C1", VA = "0x1ECE8C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C300", Offset = "0x19C401")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x1ECE8D0", Offset = "0x1ECE9D1", VA = "0x1ECE8D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C310", Offset = "0x19C411")]
		set
		{
		}
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002BA")]
	private Camera CurrentCamera
	{
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x1ECE8E0", Offset = "0x1ECE9E1", VA = "0x1ECE8E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x1ECE9A0", Offset = "0x1ECEAA1", VA = "0x1ECE9A0")]
	public void Init()
	{
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x1ECEBF0", Offset = "0x1ECECF1", VA = "0x1ECEBF0")]
	private void LoadClip_internal(SoundID soundID)
	{
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00007380 File Offset: 0x00005580
	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x1ECED70", Offset = "0x1ECEE71", VA = "0x1ECED70")]
	public bool Regist(Character chara, FootSteps controller)
	{
		return default(bool);
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x00007398 File Offset: 0x00005598
	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x1ECEDE0", Offset = "0x1ECEEE1", VA = "0x1ECEDE0")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x1ECEE50", Offset = "0x1ECEF51", VA = "0x1ECEE50")]
	public FootSteps Get(Character chara)
	{
		return null;
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x1ECEF00", Offset = "0x1ECF001", VA = "0x1ECEF00")]
	private void Update()
	{
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x1ECF050", Offset = "0x1ECF151", VA = "0x1ECF050")]
	public void OnFootSteps(Character chara, int no, bool effectPlay, float locomotion)
	{
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x1ED0210", Offset = "0x1ED0311", VA = "0x1ED0210")]
	public void OnLanding(Character chara, bool soundPlay, bool effectPlay)
	{
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x000073B0 File Offset: 0x000055B0
	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x1ECF650", Offset = "0x1ECF751", VA = "0x1ECF650")]
	public GroundType GetGroundType(Character chara, Vector3 origin, out Vector3 position, float offset, float distance, bool inWater, out Collider hitCollider)
	{
		return GroundType.Dirt;
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x1ED0770", Offset = "0x1ED0871", VA = "0x1ED0770")]
	private string TerrainFootStepsString(Collider hit, Vector3 point)
	{
		return null;
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x000073C8 File Offset: 0x000055C8
	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x1ED0A70", Offset = "0x1ED0B71", VA = "0x1ED0A70")]
	private GroundType GetGroundType(string name)
	{
		return GroundType.Dirt;
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x1ECFA60", Offset = "0x1ECFB61", VA = "0x1ECFA60")]
	private void PlayStepSound(AudioSource audioSource, Vector3 position, SoundID soundID, float basePitch, bool decay)
	{
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x1ECFD40", Offset = "0x1ECFE41", VA = "0x1ECFD40")]
	private void PlayStepEffect(Vector3 position, Quaternion rot, EffectID effectID, float scale)
	{
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x000073E0 File Offset: 0x000055E0
	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x1ECFEC0", Offset = "0x1ECFFC1", VA = "0x1ECFEC0")]
	private bool IsParty(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x1ECFFE0", Offset = "0x1ED00E1", VA = "0x1ECFFE0")]
	public void PlayNoize(Vector3 center, float radius)
	{
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x1ED19B0", Offset = "0x1ED1AB1", VA = "0x1ED19B0")]
	public FootStepsManager()
	{
	}

	// Token: 0x04000912 RID: 2322
	[Token(Token = "0x4000722")]
	protected const float kBackstepDistance = 0.05f;

	// Token: 0x04000913 RID: 2323
	[Token(Token = "0x4000723")]
	protected const float kNoizeRadiusLanding = 0.5f;

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000724")]
	protected const float kFootdownDistance = 0.1f;

	// Token: 0x04000915 RID: 2325
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, FootSteps> m_Register;

	// Token: 0x04000916 RID: 2326
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LayerMask m_ObstacleLayer;

	// Token: 0x04000917 RID: 2327
	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve m_NoizeRadius;

	// Token: 0x04000918 RID: 2328
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x30")]
	private List<float> m_TimeCountList;

	// Token: 0x04000919 RID: 2329
	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E990", Offset = "0x15EA91")]
	private int <LoadCounter>k__BackingField;

	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<SoundID, AudioClip> FootStepsSEDic;

	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200100D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1572D0", Offset = "0x1573D1")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06000FFE RID: 4094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C78")]
		[Address(RVA = "0x1ECED60", Offset = "0x1ECEE61", VA = "0x1ECED60")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C79")]
		[Address(RVA = "0x1ED1AE0", Offset = "0x1ED1BE1", VA = "0x1ED1AE0")]
		internal void <LoadClip_internal>b__0(AssetHandle<AudioClip> handle)
		{
		}

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x4018E63")]
		[FieldOffset(Offset = "0x10")]
		public FootStepsManager <>4__this;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x4018E64")]
		[FieldOffset(Offset = "0x18")]
		public SoundID soundID;
	}
}

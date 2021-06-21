using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000287 RID: 647
[Token(Token = "0x2000202")]
public class PlayerManager : MonoBehaviour
{
	// Token: 0x170002F2 RID: 754
	// (get) Token: 0x06001087 RID: 4231 RVA: 0x00007980 File Offset: 0x00005B80
	// (set) Token: 0x06001088 RID: 4232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C8")]
	public static bool IsActive
	{
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x24950C0", Offset = "0x24951C1", VA = "0x24950C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C3E0", Offset = "0x19C4E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x2495110", Offset = "0x2495211", VA = "0x2495110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C3F0", Offset = "0x19C4F1")]
		private set
		{
		}
	}

	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x06001089 RID: 4233 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600108A RID: 4234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C9")]
	public static Actor Actor
	{
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x2495170", Offset = "0x2495271", VA = "0x2495170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C400", Offset = "0x19C501")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x24951C0", Offset = "0x24952C1", VA = "0x24951C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C410", Offset = "0x19C511")]
		private set
		{
		}
	}

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x0600108B RID: 4235 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600108C RID: 4236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002CA")]
	public static Character Character
	{
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x2495220", Offset = "0x2495321", VA = "0x2495220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C420", Offset = "0x19C521")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x2495270", Offset = "0x2495371", VA = "0x2495270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C430", Offset = "0x19C531")]
		private set
		{
		}
	}

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x0600108D RID: 4237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002CB")]
	public static CharacterStatusBase StatusController
	{
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x24952D0", Offset = "0x24953D1", VA = "0x24952D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x0600108E RID: 4238 RVA: 0x00007998 File Offset: 0x00005B98
	[Token(Token = "0x170002CC")]
	public static bool IsDead
	{
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x24953E0", Offset = "0x24954E1", VA = "0x24953E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002CD")]
	public static PlayerInput PlayerInput
	{
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x2495500", Offset = "0x2495601", VA = "0x2495500")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002CE")]
	public static PlayerCameraController PlayerCameraController
	{
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x2495600", Offset = "0x2495701", VA = "0x2495600")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x06001091 RID: 4241 RVA: 0x000079B0 File Offset: 0x00005BB0
	// (set) Token: 0x06001092 RID: 4242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002CF")]
	public float SeedSupportCountdown
	{
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x2495700", Offset = "0x2495801", VA = "0x2495700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C440", Offset = "0x19C541")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x2495710", Offset = "0x2495811", VA = "0x2495710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C450", Offset = "0x19C551")]
		private set
		{
		}
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x2495720", Offset = "0x2495821", VA = "0x2495720")]
	public static void SetPlayer(Character character)
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x24958C0", Offset = "0x24959C1", VA = "0x24958C0")]
	public static void SpawnPlayer(Vector3 position, Quaternion rotation)
	{
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F06")]
	[Address(RVA = "0x2495A60", Offset = "0x2495B61", VA = "0x2495A60")]
	public static void SpawnPlayer()
	{
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F07")]
	[Address(RVA = "0x2495BE0", Offset = "0x2495CE1", VA = "0x2495BE0")]
	public static void ResetPosition()
	{
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x06001097 RID: 4247 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002D0")]
	private static PlayerManager Instance
	{
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x2495DC0", Offset = "0x2495EC1", VA = "0x2495DC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C460", Offset = "0x19C561")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x2495E10", Offset = "0x2495F11", VA = "0x2495E10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C470", Offset = "0x19C571")]
		set
		{
		}
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06001099 RID: 4249 RVA: 0x000079C8 File Offset: 0x00005BC8
	// (set) Token: 0x0600109A RID: 4250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002D1")]
	private Vector3 SpawnPosition
	{
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x2495E70", Offset = "0x2495F71", VA = "0x2495E70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C480", Offset = "0x19C581")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x2495E80", Offset = "0x2495F81", VA = "0x2495E80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C490", Offset = "0x19C591")]
		set
		{
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x0600109B RID: 4251 RVA: 0x000079E0 File Offset: 0x00005BE0
	// (set) Token: 0x0600109C RID: 4252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002D2")]
	private Quaternion SpawnRotation
	{
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x2495E90", Offset = "0x2495F91", VA = "0x2495E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C4A0", Offset = "0x19C5A1")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x2495EA0", Offset = "0x2495FA1", VA = "0x2495EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C4B0", Offset = "0x19C5B1")]
		set
		{
		}
	}

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x0600109D RID: 4253 RVA: 0x000079F8 File Offset: 0x00005BF8
	// (set) Token: 0x0600109E RID: 4254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002D3")]
	private float DeadTime
	{
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x2495EC0", Offset = "0x2495FC1", VA = "0x2495EC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C4C0", Offset = "0x19C5C1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x2495ED0", Offset = "0x2495FD1", VA = "0x2495ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C4D0", Offset = "0x19C5D1")]
		set
		{
		}
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F10")]
	[Address(RVA = "0x2495EE0", Offset = "0x2495FE1", VA = "0x2495EE0")]
	private void Init()
	{
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F11")]
	[Address(RVA = "0x2495FC0", Offset = "0x24960C1", VA = "0x2495FC0")]
	private void Awake()
	{
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F12")]
	[Address(RVA = "0x24960C0", Offset = "0x24961C1", VA = "0x24960C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F13")]
	[Address(RVA = "0x24960D0", Offset = "0x24961D1", VA = "0x24960D0")]
	private void Start()
	{
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x2496180", Offset = "0x2496281", VA = "0x2496180")]
	private void Update()
	{
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x2496BF0", Offset = "0x2496CF1", VA = "0x2496BF0")]
	private void InitSeedSupportParam()
	{
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x00007A10 File Offset: 0x00005C10
	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x2496900", Offset = "0x2496A01", VA = "0x2496900")]
	private bool UpdateSeedSupport()
	{
		return default(bool);
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x2496C20", Offset = "0x2496D21", VA = "0x2496C20")]
	private void OnNextDay(int carryDay)
	{
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x2496F20", Offset = "0x2497021", VA = "0x2496F20")]
	public PlayerManager()
	{
	}

	// Token: 0x0400094C RID: 2380
	[Token(Token = "0x400075A")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB40", Offset = "0x15EC41")]
	private static bool <IsActive>k__BackingField;

	// Token: 0x0400094D RID: 2381
	[Token(Token = "0x400075B")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB50", Offset = "0x15EC51")]
	private static Actor <Actor>k__BackingField;

	// Token: 0x0400094E RID: 2382
	[Token(Token = "0x400075C")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB60", Offset = "0x15EC61")]
	private static Character <Character>k__BackingField;

	// Token: 0x0400094F RID: 2383
	[Token(Token = "0x400075D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PlayerInput playerInput;

	// Token: 0x04000950 RID: 2384
	[Token(Token = "0x400075E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PlayerCameraController playerCamera;

	// Token: 0x04000951 RID: 2385
	[Token(Token = "0x400075F")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB90", Offset = "0x15EC91")]
	private float <SeedSupportCountdown>k__BackingField;

	// Token: 0x04000952 RID: 2386
	[Token(Token = "0x4000760")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EBA0", Offset = "0x15ECA1")]
	private static PlayerManager <Instance>k__BackingField;

	// Token: 0x04000953 RID: 2387
	[Token(Token = "0x4000761")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EBB0", Offset = "0x15ECB1")]
	private Vector3 <SpawnPosition>k__BackingField;

	// Token: 0x04000954 RID: 2388
	[Token(Token = "0x4000762")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EBC0", Offset = "0x15ECC1")]
	private Quaternion <SpawnRotation>k__BackingField;

	// Token: 0x04000955 RID: 2389
	[Token(Token = "0x4000763")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EBD0", Offset = "0x15ECD1")]
	private float <DeadTime>k__BackingField;

	// Token: 0x04000956 RID: 2390
	[Token(Token = "0x4000764")]
	[FieldOffset(Offset = "0x4C")]
	private PlayerManager.STATE updateState;

	// Token: 0x02000288 RID: 648
	[Token(Token = "0x200100E")]
	private enum STATE
	{
		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4018E66")]
		NONE,
		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4018E67")]
		INIT,
		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x4018E68")]
		IDLE,
		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x4018E69")]
		DIED,
		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x4018E6A")]
		REVIVAL
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004E0 RID: 1248
[Token(Token = "0x2000397")]
public class BaffamoDodgeManager : SingletonMonoBehaviour<BaffamoDodgeManager>
{
	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000413")]
	public FestivalCamera Camera
	{
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x229C4C0", Offset = "0x229C5C1", VA = "0x229C4C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06001E93 RID: 7827 RVA: 0x0000D080 File Offset: 0x0000B280
	// (set) Token: 0x06001E94 RID: 7828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000414")]
	public Vector3 StartForward
	{
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x229C4D0", Offset = "0x229C5D1", VA = "0x229C4D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F570", Offset = "0x19F671")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x229C4E0", Offset = "0x229C5E1", VA = "0x229C4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F580", Offset = "0x19F681")]
		private set
		{
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E96 RID: 7830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000415")]
	public ParticleSystem[] BaffamoRushEffect
	{
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x229C4F0", Offset = "0x229C5F1", VA = "0x229C4F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F590", Offset = "0x19F691")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x229C500", Offset = "0x229C601", VA = "0x229C500")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F5A0", Offset = "0x19F6A1")]
		private set
		{
		}
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x229C510", Offset = "0x229C611", VA = "0x229C510", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x229C580", Offset = "0x229C681", VA = "0x229C580")]
	private void Start()
	{
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x229C850", Offset = "0x229C951", VA = "0x229C850")]
	private void LoadEffect(int _i)
	{
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A57")]
	[Address(RVA = "0x229C950", Offset = "0x229CA51", VA = "0x229C950")]
	private void CharaSetup()
	{
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x0000D098 File Offset: 0x0000B298
	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x229CAD0", Offset = "0x229CBD1", VA = "0x229CAD0")]
	private bool IsLoading()
	{
		return default(bool);
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A59")]
	[Address(RVA = "0x229CC00", Offset = "0x229CD01", VA = "0x229CC00")]
	private void Update()
	{
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A5A")]
	[Address(RVA = "0x229CF90", Offset = "0x229D091", VA = "0x229CF90")]
	private void InitBaffamo()
	{
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A5B")]
	[Address(RVA = "0x229D8B0", Offset = "0x229D9B1", VA = "0x229D8B0")]
	private void LoadBaffamo(BaffamoDodgeManager.BaffamoMonster _baffamo)
	{
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x229D9F0", Offset = "0x229DAF1", VA = "0x229D9F0")]
	private void SummonBaffamo(BaffamoID _id, int _count)
	{
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x229DBC0", Offset = "0x229DCC1", VA = "0x229DBC0")]
	private void PrepareBaffamo()
	{
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A5E")]
	[Address(RVA = "0x229D470", Offset = "0x229D571", VA = "0x229D470")]
	private void ResetBaffamo()
	{
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x229D2F0", Offset = "0x229D3F1", VA = "0x229D2F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F5B0", Offset = "0x19F6B1")]
	private IEnumerator BaffamoGame()
	{
		return null;
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A60")]
	[Address(RVA = "0x229E1C0", Offset = "0x229E2C1", VA = "0x229E1C0")]
	public void Dodge()
	{
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x229E680", Offset = "0x229E781", VA = "0x229E680")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F620", Offset = "0x19F721")]
	private IEnumerator CheckNormalRolling(BaffamoDodgeManager.BaffamoMonster _baffamo)
	{
		return null;
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A62")]
	[Address(RVA = "0x229E750", Offset = "0x229E851", VA = "0x229E750")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F690", Offset = "0x19F791")]
	private IEnumerator CameraZoom()
	{
		return null;
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A63")]
	[Address(RVA = "0x229D370", Offset = "0x229D471", VA = "0x229D370")]
	public void PlayJudgeCutin()
	{
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A64")]
	[Address(RVA = "0x229EA30", Offset = "0x229EB31", VA = "0x229EA30")]
	public void HitBaffamo(Vector3 _forward)
	{
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
	[Token(Token = "0x6001A65")]
	[Address(RVA = "0x229EC10", Offset = "0x229ED11", VA = "0x229EC10")]
	public float CheckZone(Vector3 _player_pos)
	{
		return 0f;
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A66")]
	[Address(RVA = "0x229E800", Offset = "0x229E901", VA = "0x229E800")]
	private void PlayRollingSE(AvoidType _type)
	{
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x229ECE0", Offset = "0x229EDE1", VA = "0x229ECE0")]
	public BaffamoDodgeManager()
	{
	}

	// Token: 0x0400658E RID: 25998
	[Token(Token = "0x400602E")]
	[FieldOffset(Offset = "0x18")]
	private List<BaffamoDodgeManager.BaffamoMonster> Baffamos;

	// Token: 0x0400658F RID: 25999
	[Token(Token = "0x400602F")]
	[FieldOffset(Offset = "0x20")]
	private BaffamoFestivalDataTable baffamoFestivalDataTable;

	// Token: 0x04006590 RID: 26000
	[Token(Token = "0x4006030")]
	[FieldOffset(Offset = "0x28")]
	public readonly float FESTIVAL_ZONE_RADIUS;

	// Token: 0x04006591 RID: 26001
	[Token(Token = "0x4006031")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private FestivalCamera baffamoCamera;

	// Token: 0x04006592 RID: 26002
	[Token(Token = "0x4006032")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165450", Offset = "0x165551")]
	private Vector3 <StartForward>k__BackingField;

	// Token: 0x04006593 RID: 26003
	[Token(Token = "0x4006033")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165460", Offset = "0x165561")]
	private ParticleSystem[] <BaffamoRushEffect>k__BackingField;

	// Token: 0x04006594 RID: 26004
	[Token(Token = "0x4006034")]
	[FieldOffset(Offset = "0x50")]
	private BaffamoUI baffamoUI;

	// Token: 0x04006595 RID: 26005
	[Token(Token = "0x4006035")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject festivalZone;

	// Token: 0x04006596 RID: 26006
	[Token(Token = "0x4006036")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject[] baffamoStartPos;

	// Token: 0x04006597 RID: 26007
	[Token(Token = "0x4006037")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject baffamoEndPos;

	// Token: 0x04006598 RID: 26008
	[Token(Token = "0x4006038")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject playerPos;

	// Token: 0x04006599 RID: 26009
	[Token(Token = "0x4006039")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject cameraStartPos;

	// Token: 0x0400659A RID: 26010
	[Token(Token = "0x400603A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ParticleSystem focusLine;

	// Token: 0x0400659B RID: 26011
	[Token(Token = "0x400603B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float ZOOM_TIME;

	// Token: 0x0400659C RID: 26012
	[Token(Token = "0x400603C")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private float zoomSpeed;

	// Token: 0x0400659D RID: 26013
	[Token(Token = "0x400603D")]
	[FieldOffset(Offset = "0x90")]
	private int loadCount;

	// Token: 0x0400659E RID: 26014
	[Token(Token = "0x400603E")]
	[FieldOffset(Offset = "0x94")]
	private float currentZoomTime;

	// Token: 0x0400659F RID: 26015
	[Token(Token = "0x400603F")]
	[FieldOffset(Offset = "0x98")]
	private bool isCameraZoom;

	// Token: 0x040065A0 RID: 26016
	[Token(Token = "0x4006040")]
	[FieldOffset(Offset = "0x9C")]
	private AvoidType avoid;

	// Token: 0x040065A1 RID: 26017
	[Token(Token = "0x4006041")]
	[FieldOffset(Offset = "0xA0")]
	private BaffamoDodgeManager.State state;

	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20010D2")]
	public class BaffamoMonster
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C8F")]
		public BaffamoFestivalData BaffamoData
		{
			[Token(Token = "0x6006F2E")]
			[Address(RVA = "0x229FFD0", Offset = "0x22A00D1", VA = "0x229FFD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1630", Offset = "0x1B1731")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F2F")]
			[Address(RVA = "0x229FFE0", Offset = "0x22A00E1", VA = "0x229FFE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1640", Offset = "0x1B1741")]
			private set
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C90")]
		public BaffamoFestivalController BaffamoFestivalController
		{
			[Token(Token = "0x6006F30")]
			[Address(RVA = "0x229FFF0", Offset = "0x22A00F1", VA = "0x229FFF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1650", Offset = "0x1B1751")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F31")]
			[Address(RVA = "0x22A0000", Offset = "0x22A0101", VA = "0x22A0000")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1660", Offset = "0x1B1761")]
			private set
			{
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F32")]
		[Address(RVA = "0x229D870", Offset = "0x229D971", VA = "0x229D870")]
		public BaffamoMonster(BaffamoFestivalData _data)
		{
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F33")]
		[Address(RVA = "0x229F3E0", Offset = "0x229F4E1", VA = "0x229F3E0")]
		public void SetController(BaffamoFestivalController _festival_controller)
		{
		}

		// Token: 0x040065A2 RID: 26018
		[Token(Token = "0x40191D3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F80", Offset = "0x195081")]
		private BaffamoFestivalData <BaffamoData>k__BackingField;

		// Token: 0x040065A3 RID: 26019
		[Token(Token = "0x40191D4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F90", Offset = "0x195091")]
		private BaffamoFestivalController <BaffamoFestivalController>k__BackingField;
	}

	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20010D3")]
	private enum State
	{
		// Token: 0x040065A5 RID: 26021
		[Token(Token = "0x40191D6")]
		None,
		// Token: 0x040065A6 RID: 26022
		[Token(Token = "0x40191D7")]
		Begin,
		// Token: 0x040065A7 RID: 26023
		[Token(Token = "0x40191D8")]
		Load,
		// Token: 0x040065A8 RID: 26024
		[Token(Token = "0x40191D9")]
		CountDown,
		// Token: 0x040065A9 RID: 26025
		[Token(Token = "0x40191DA")]
		Main,
		// Token: 0x040065AA RID: 26026
		[Token(Token = "0x40191DB")]
		End
	}

	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20010D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157BA0", Offset = "0x157CA1")]
	private sealed class <>c__DisplayClass32_0
	{
		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F34")]
		[Address(RVA = "0x229C940", Offset = "0x229CA41", VA = "0x229C940")]
		public <>c__DisplayClass32_0()
		{
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F35")]
		[Address(RVA = "0x229EF70", Offset = "0x229F071", VA = "0x229EF70")]
		internal void <LoadEffect>b__0(ParticleSystem _effect)
		{
		}

		// Token: 0x040065AB RID: 26027
		[Token(Token = "0x40191DC")]
		[FieldOffset(Offset = "0x10")]
		public BaffamoDodgeManager <>4__this;

		// Token: 0x040065AC RID: 26028
		[Token(Token = "0x40191DD")]
		[FieldOffset(Offset = "0x18")]
		public int _i;
	}

	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20010D5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157BB0", Offset = "0x157CB1")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x06001EB3 RID: 7859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F36")]
		[Address(RVA = "0x229D9E0", Offset = "0x229DAE1", VA = "0x229D9E0")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F37")]
		[Address(RVA = "0x229F000", Offset = "0x229F101", VA = "0x229F000")]
		internal void <LoadBaffamo>b__0(GameObject _controller)
		{
		}

		// Token: 0x040065AD RID: 26029
		[Token(Token = "0x40191DE")]
		[FieldOffset(Offset = "0x10")]
		public BaffamoDodgeManager.BaffamoMonster _baffamo;

		// Token: 0x040065AE RID: 26030
		[Token(Token = "0x40191DF")]
		[FieldOffset(Offset = "0x18")]
		public BaffamoDodgeManager <>4__this;
	}

	// Token: 0x020004E5 RID: 1253
	[Token(Token = "0x20010D6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157BC0", Offset = "0x157CC1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001EB6 RID: 7862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F39")]
		[Address(RVA = "0x229EE80", Offset = "0x229EF81", VA = "0x229EE80")]
		public <>c()
		{
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x6006F3A")]
		[Address(RVA = "0x229EE90", Offset = "0x229EF91", VA = "0x229EE90")]
		internal bool <BaffamoGame>b__41_0()
		{
			return default(bool);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0x229EF00", Offset = "0x229F001", VA = "0x229EF00")]
		internal bool <BaffamoGame>b__41_1()
		{
			return default(bool);
		}

		// Token: 0x040065AF RID: 26031
		[Token(Token = "0x40191E0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BaffamoDodgeManager.<>c <>9;

		// Token: 0x040065B0 RID: 26032
		[Token(Token = "0x40191E1")]
		[FieldOffset(Offset = "0x8")]
		public static Func<bool> <>9__41_0;

		// Token: 0x040065B1 RID: 26033
		[Token(Token = "0x40191E2")]
		[FieldOffset(Offset = "0x10")]
		public static Func<bool> <>9__41_1;
	}

	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20010D7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157BD0", Offset = "0x157CD1")]
	private sealed class <BaffamoGame>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3C")]
		[Address(RVA = "0x229E190", Offset = "0x229E291", VA = "0x229E190")]
		[DebuggerHidden]
		public <BaffamoGame>d__41(int <>1__state)
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3D")]
		[Address(RVA = "0x229F3F0", Offset = "0x229F4F1", VA = "0x229F3F0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		[Token(Token = "0x6006F3E")]
		[Address(RVA = "0x229F400", Offset = "0x229F501", VA = "0x229F400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C91")]
		private object Current
		{
			[Token(Token = "0x6006F3F")]
			[Address(RVA = "0x229F7F0", Offset = "0x229F8F1", VA = "0x229F7F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F40")]
		[Address(RVA = "0x229F800", Offset = "0x229F901", VA = "0x229F800", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C92")]
		private object Current
		{
			[Token(Token = "0x6006F41")]
			[Address(RVA = "0x229F860", Offset = "0x229F961", VA = "0x229F860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040065B2 RID: 26034
		[Token(Token = "0x40191E3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040065B3 RID: 26035
		[Token(Token = "0x40191E4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040065B4 RID: 26036
		[Token(Token = "0x40191E5")]
		[FieldOffset(Offset = "0x20")]
		public BaffamoDodgeManager <>4__this;
	}

	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20010D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157BE0", Offset = "0x157CE1")]
	private sealed class <CheckNormalRolling>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001EBF RID: 7871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F42")]
		[Address(RVA = "0x229E720", Offset = "0x229E821", VA = "0x229E720")]
		[DebuggerHidden]
		public <CheckNormalRolling>d__43(int <>1__state)
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F43")]
		[Address(RVA = "0x229FD70", Offset = "0x229FE71", VA = "0x229FD70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x6006F44")]
		[Address(RVA = "0x229FD80", Offset = "0x229FE81", VA = "0x229FD80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C93")]
		private object Current
		{
			[Token(Token = "0x6006F45")]
			[Address(RVA = "0x229FF50", Offset = "0x22A0051", VA = "0x229FF50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F46")]
		[Address(RVA = "0x229FF60", Offset = "0x22A0061", VA = "0x229FF60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C94")]
		private object Current
		{
			[Token(Token = "0x6006F47")]
			[Address(RVA = "0x229FFC0", Offset = "0x22A00C1", VA = "0x229FFC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040065B5 RID: 26037
		[Token(Token = "0x40191E6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040065B6 RID: 26038
		[Token(Token = "0x40191E7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040065B7 RID: 26039
		[Token(Token = "0x40191E8")]
		[FieldOffset(Offset = "0x20")]
		public BaffamoDodgeManager.BaffamoMonster _baffamo;

		// Token: 0x040065B8 RID: 26040
		[Token(Token = "0x40191E9")]
		[FieldOffset(Offset = "0x28")]
		public BaffamoDodgeManager <>4__this;

		// Token: 0x040065B9 RID: 26041
		[Token(Token = "0x40191EA")]
		[FieldOffset(Offset = "0x30")]
		private bool <dodgeSuccess>5__2;
	}

	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20010D9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157BF0", Offset = "0x157CF1")]
	private sealed class <CameraZoom>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F48")]
		[Address(RVA = "0x229E7D0", Offset = "0x229E8D1", VA = "0x229E7D0")]
		[DebuggerHidden]
		public <CameraZoom>d__44(int <>1__state)
		{
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F49")]
		[Address(RVA = "0x229F870", Offset = "0x229F971", VA = "0x229F870", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x6006F4A")]
		[Address(RVA = "0x229F880", Offset = "0x229F981", VA = "0x229F880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C95")]
		private object Current
		{
			[Token(Token = "0x6006F4B")]
			[Address(RVA = "0x229FCF0", Offset = "0x229FDF1", VA = "0x229FCF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4C")]
		[Address(RVA = "0x229FD00", Offset = "0x229FE01", VA = "0x229FD00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C96")]
		private object Current
		{
			[Token(Token = "0x6006F4D")]
			[Address(RVA = "0x229FD60", Offset = "0x229FE61", VA = "0x229FD60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040065BA RID: 26042
		[Token(Token = "0x40191EB")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040065BB RID: 26043
		[Token(Token = "0x40191EC")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040065BC RID: 26044
		[Token(Token = "0x40191ED")]
		[FieldOffset(Offset = "0x20")]
		public BaffamoDodgeManager <>4__this;
	}
}

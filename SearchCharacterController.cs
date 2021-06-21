using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016A RID: 362
[Token(Token = "0x200011A")]
public class SearchCharacterController
{
	// Token: 0x17000184 RID: 388
	// (get) Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600077F RID: 1919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000170")]
	protected Transform HeadTransform
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x21E3440", Offset = "0x21E3541", VA = "0x21E3440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A8E0", Offset = "0x19A9E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x21E3450", Offset = "0x21E3551", VA = "0x21E3450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A8F0", Offset = "0x19A9F1")]
		set
		{
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000780 RID: 1920 RVA: 0x00004AB8 File Offset: 0x00002CB8
	// (set) Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000171")]
	public float MaxDistance
	{
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x21E3460", Offset = "0x21E3561", VA = "0x21E3460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A900", Offset = "0x19AA01")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x21E3470", Offset = "0x21E3571", VA = "0x21E3470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A910", Offset = "0x19AA11")]
		protected set
		{
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000782 RID: 1922 RVA: 0x00004AD0 File Offset: 0x00002CD0
	// (set) Token: 0x06000783 RID: 1923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000172")]
	public int MaxDistanceType
	{
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x21E3480", Offset = "0x21E3581", VA = "0x21E3480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A920", Offset = "0x19AA21")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x21E3490", Offset = "0x21E3591", VA = "0x21E3490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A930", Offset = "0x19AA31")]
		protected set
		{
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000173")]
	public Dictionary<int, List<Character>> FindCharacterListDic
	{
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x21E34A0", Offset = "0x21E35A1", VA = "0x21E34A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A940", Offset = "0x19AA41")]
		get
		{
			return null;
		}
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x21E34B0", Offset = "0x21E35B1", VA = "0x21E34B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A950", Offset = "0x19AA51")]
		private set
		{
		}
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065F")]
	[Address(RVA = "0x21E34C0", Offset = "0x21E35C1", VA = "0x21E34C0")]
	public void SetIgnoreCharacterFunc([Optional] Func<Character, bool> ignoreCharacterFunc)
	{
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000660")]
	[Address(RVA = "0x21E34D0", Offset = "0x21E35D1", VA = "0x21E34D0")]
	public void ClearFindCharacterList()
	{
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000661")]
	[Address(RVA = "0x21E35C0", Offset = "0x21E36C1", VA = "0x21E35C0")]
	public void Setup(Vector3 offsetPosition, Vector3 forwardDirection, Transform headTransform)
	{
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000662")]
	[Address(RVA = "0x21E36A0", Offset = "0x21E37A1", VA = "0x21E36A0")]
	public void Setup(Vector3 offsetPosition, [Optional] Transform headTransform)
	{
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000663")]
	[Address(RVA = "0x21E37D0", Offset = "0x21E38D1", VA = "0x21E37D0", Slot = "4")]
	protected virtual void OnSetup()
	{
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000664")]
	[Address(RVA = "0x21E37E0", Offset = "0x21E38E1", VA = "0x21E37E0")]
	public void SetTickTime(float tickTime)
	{
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000665")]
	[Address(RVA = "0x21E37F0", Offset = "0x21E38F1", VA = "0x21E37F0")]
	public void AddSearchParameter(int type, float angle, float distance)
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000666")]
	[Address(RVA = "0x21E38A0", Offset = "0x21E39A1", VA = "0x21E38A0")]
	public void AddSearchParameter(int type, float angle, float distance, Vector3 localDirection)
	{
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000667")]
	[Address(RVA = "0x21E3A00", Offset = "0x21E3B01", VA = "0x21E3A00")]
	public SearchCharacterController.SearchParameter GetSearchParameter(int type)
	{
		return null;
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000668")]
	[Address(RVA = "0x21E3B20", Offset = "0x21E3C21", VA = "0x21E3B20")]
	public List<Character> GetFindCharacterList()
	{
		return null;
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000669")]
	[Address(RVA = "0x21E3B80", Offset = "0x21E3C81", VA = "0x21E3B80")]
	public void ChangeSearchParameter(int type, float angle, float distance)
	{
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x21E3CC0", Offset = "0x21E3DC1", VA = "0x21E3CC0")]
	public void Update()
	{
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x21E3D30", Offset = "0x21E3E31", VA = "0x21E3D30")]
	public void Tick()
	{
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x21E4480", Offset = "0x21E4581", VA = "0x21E4480", Slot = "5")]
	protected virtual void OnBeforeTick()
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066D")]
	[Address(RVA = "0x21E4490", Offset = "0x21E4591", VA = "0x21E4490", Slot = "6")]
	protected virtual void OnFindCharacter(Character character, int searchParameterType)
	{
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x600066E")]
	[Address(RVA = "0x21E42C0", Offset = "0x21E43C1", VA = "0x21E42C0")]
	private bool CheckSerchParameter(float angle, float sqrMagnitude, Vector3 targetPosition, SearchCharacterController.SearchParameter parameter, Collider collider, bool isCheckObstacle = false)
	{
		return default(bool);
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x21E44A0", Offset = "0x21E45A1", VA = "0x21E44A0")]
	public void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000670")]
	[Address(RVA = "0x21E44B0", Offset = "0x21E45B1", VA = "0x21E44B0")]
	public SearchCharacterController()
	{
	}

	// Token: 0x04000463 RID: 1123
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float TickTime;

	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 ForwardDirection;

	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 OffsetPosition;

	// Token: 0x04000466 RID: 1126
	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float timer;

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C000", Offset = "0x15C101")]
	private Transform <HeadTransform>k__BackingField;

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C010", Offset = "0x15C111")]
	private float <MaxDistance>k__BackingField;

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C020", Offset = "0x15C121")]
	private int <MaxDistanceType>k__BackingField;

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool IsSetup;

	// Token: 0x0400046B RID: 1131
	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool IsTick;

	// Token: 0x0400046C RID: 1132
	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Collider[] results;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<SearchCharacterController.SearchParameter> SearchParameterList;

	// Token: 0x0400046E RID: 1134
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C030", Offset = "0x15C131")]
	private Dictionary<int, List<Character>> <FindCharacterListDic>k__BackingField;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Character> CheckCharacterList;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Func<Character, bool> IgnoreCharacterFunc;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private RaycastHit ObjectHit;

	// Token: 0x0200016B RID: 363
	[Token(Token = "0x2000FD9")]
	public class SearchParameter
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C12")]
		[Address(RVA = "0x21E39F0", Offset = "0x21E3AF1", VA = "0x21E39F0")]
		public SearchParameter()
		{
		}

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4018D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Type;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4018D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Distance;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4018D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Angle;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4018D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 LocalDirection;
	}

	// Token: 0x0200016C RID: 364
	[Token(Token = "0x2000FDA")]
	public class FindCharacterParameter
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C13")]
		[Address(RVA = "0x21E4610", Offset = "0x21E4711", VA = "0x21E4610")]
		public FindCharacterParameter()
		{
		}

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4018D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Character Character;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4018D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SearchType;
	}
}

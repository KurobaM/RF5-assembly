using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x020010FF RID: 4351
	[Token(Token = "0x2000AF4")]
	public class IndoorShadowManager : SingletonMonoBehaviour<IndoorShadowManager>
	{
		// Token: 0x06006DF8 RID: 28152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B41")]
		[Address(RVA = "0x2028A70", Offset = "0x2028B71", VA = "0x2028A70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B42")]
		[Address(RVA = "0x2028930", Offset = "0x2028A31", VA = "0x2028930")]
		public void AddFloor(IndoorShadowFloor floorObject)
		{
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B43")]
		[Address(RVA = "0x2028790", Offset = "0x2028891", VA = "0x2028790")]
		public void RemoveFloor(IndoorShadowFloor floorObject)
		{
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x00025E18 File Offset: 0x00024018
		[Token(Token = "0x6005B44")]
		[Address(RVA = "0x2028B80", Offset = "0x2028C81", VA = "0x2028B80")]
		public bool CheckEnable()
		{
			return default(bool);
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B45")]
		[Address(RVA = "0x2028C70", Offset = "0x2028D71", VA = "0x2028C70", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B46")]
		[Address(RVA = "0x20290F0", Offset = "0x20291F1", VA = "0x20290F0")]
		private void Update()
		{
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B47")]
		[Address(RVA = "0x2029350", Offset = "0x2029451", VA = "0x2029350")]
		private void UpdateCharacter(bool isUseCulling)
		{
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0x20296D0", Offset = "0x20297D1", VA = "0x20296D0")]
		private void UpdateSpcItem(bool isUseCulling)
		{
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0x2029D40", Offset = "0x2029E41", VA = "0x2029D40")]
		public void AddSpcItem(GameObject gameObject)
		{
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0x2029DD0", Offset = "0x2029ED1", VA = "0x2029DD0")]
		public void RemoveSpcItem(GameObject gameObject)
		{
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0x2029B00", Offset = "0x2029C01", VA = "0x2029B00")]
		private void UpdateFurniture(bool isUseCulling)
		{
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0x2029C20", Offset = "0x2029D21", VA = "0x2029C20")]
		private void UpdateGroundItem(bool isUseCulling)
		{
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x00025E30 File Offset: 0x00024030
		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0x2029E40", Offset = "0x2029F41", VA = "0x2029E40")]
		private int CheckFloorIndex(float height)
		{
			return 0;
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x00025E48 File Offset: 0x00024048
		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0x2029EC0", Offset = "0x2029FC1", VA = "0x2029EC0")]
		public static bool CheckEnableMeshShadow(float checkHeight)
		{
			return default(bool);
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B4F")]
		[Address(RVA = "0x2028BE0", Offset = "0x2028CE1", VA = "0x2028BE0")]
		private void ResetShadow()
		{
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B50")]
		[Address(RVA = "0x2029FA0", Offset = "0x202A0A1", VA = "0x2029FA0")]
		private void ResetMeshShadowCharacter()
		{
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B51")]
		[Address(RVA = "0x202A160", Offset = "0x202A261", VA = "0x202A160")]
		private void ResetSpcItem()
		{
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B52")]
		[Address(RVA = "0x2028CD0", Offset = "0x2028DD1", VA = "0x2028CD0")]
		private void SetCullingGroup()
		{
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B53")]
		[Address(RVA = "0x202A360", Offset = "0x202A461", VA = "0x202A360")]
		private void OnChange(CullingGroupEvent ev)
		{
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B54")]
		[Address(RVA = "0x202A3D0", Offset = "0x202A4D1", VA = "0x202A3D0")]
		public IndoorShadowManager()
		{
		}

		// Token: 0x040180C4 RID: 98500
		[Token(Token = "0x4014BA4")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<IndoorShadowFloor> IndoorShadowFloorHashSet;

		// Token: 0x040180C5 RID: 98501
		[Token(Token = "0x4014BA5")]
		[FieldOffset(Offset = "0x20")]
		private IndoorShadowFloor IndoorShadowFloor;

		// Token: 0x040180C6 RID: 98502
		[Token(Token = "0x4014BA6")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<GameObject, Renderer[]> ItemRendererDictionary;

		// Token: 0x040180C7 RID: 98503
		[Token(Token = "0x4014BA7")]
		[FieldOffset(Offset = "0x30")]
		private bool IsEnable;

		// Token: 0x040180C8 RID: 98504
		[Token(Token = "0x4014BA8")]
		[FieldOffset(Offset = "0x34")]
		private int PlayerFloorIndex;

		// Token: 0x040180C9 RID: 98505
		[Token(Token = "0x4014BA9")]
		[FieldOffset(Offset = "0x38")]
		private CullingGroup CullingGroup;

		// Token: 0x040180CA RID: 98506
		[Token(Token = "0x4014BAA")]
		[FieldOffset(Offset = "0x40")]
		private BoundingSphere[] Bounds;

		// Token: 0x040180CB RID: 98507
		[Token(Token = "0x4014BAB")]
		[FieldOffset(Offset = "0x48")]
		private Transform[] Targets;

		// Token: 0x040180CC RID: 98508
		[Token(Token = "0x4014BAC")]
		[FieldOffset(Offset = "0x50")]
		private bool[] TargetShadowEnables;

		// Token: 0x040180CD RID: 98509
		[Token(Token = "0x4014BAD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float[] BoundingDistances;

		// Token: 0x02001100 RID: 4352
		[Token(Token = "0x2001577")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A100", Offset = "0x15A201")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006E0D RID: 28173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D67")]
			[Address(RVA = "0x202A500", Offset = "0x202A601", VA = "0x202A500")]
			public <>c()
			{
			}

			// Token: 0x06006E0E RID: 28174 RVA: 0x00025E60 File Offset: 0x00024060
			[Token(Token = "0x6007D68")]
			[Address(RVA = "0x202A510", Offset = "0x202A611", VA = "0x202A510")]
			internal bool <UpdateFurniture>b__20_0(float h)
			{
				return default(bool);
			}

			// Token: 0x06006E0F RID: 28175 RVA: 0x00025E78 File Offset: 0x00024078
			[Token(Token = "0x6007D69")]
			[Address(RVA = "0x202A520", Offset = "0x202A621", VA = "0x202A520")]
			internal bool <UpdateGroundItem>b__21_0(float h)
			{
				return default(bool);
			}

			// Token: 0x040180CE RID: 98510
			[Token(Token = "0x401C12C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly IndoorShadowManager.<>c <>9;

			// Token: 0x040180CF RID: 98511
			[Token(Token = "0x401C12D")]
			[FieldOffset(Offset = "0x8")]
			public static Func<float, bool> <>9__20_0;

			// Token: 0x040180D0 RID: 98512
			[Token(Token = "0x401C12E")]
			[FieldOffset(Offset = "0x10")]
			public static Func<float, bool> <>9__21_0;
		}
	}
}

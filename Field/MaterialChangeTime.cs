using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001102 RID: 4354
	[Token(Token = "0x2000AF6")]
	public class MaterialChangeTime : MonoBehaviour
	{
		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06006E19 RID: 28185 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E1A RID: 28186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF2")]
		public TimeParamTable[] TimeParamTables
		{
			[Token(Token = "0x6005B5E")]
			[Address(RVA = "0x202A530", Offset = "0x202A631", VA = "0x202A530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B5F")]
			[Address(RVA = "0x202A540", Offset = "0x202A641", VA = "0x202A540")]
			set
			{
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06006E1B RID: 28187 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E1C RID: 28188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF3")]
		[SerializeField]
		public RendererMaterial[] RendererMaterials
		{
			[Token(Token = "0x6005B60")]
			[Address(RVA = "0x202A550", Offset = "0x202A651", VA = "0x202A550")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B61")]
			[Address(RVA = "0x202A560", Offset = "0x202A661", VA = "0x202A560")]
			set
			{
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06006E1D RID: 28189 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E1E RID: 28190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF4")]
		public Light Light
		{
			[Token(Token = "0x6005B62")]
			[Address(RVA = "0x202A570", Offset = "0x202A671", VA = "0x202A570")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B63")]
			[Address(RVA = "0x202A580", Offset = "0x202A681", VA = "0x202A580")]
			set
			{
			}
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x202A590", Offset = "0x202A691", VA = "0x202A590")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x202A760", Offset = "0x202A861", VA = "0x202A760")]
		private void Awake()
		{
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B66")]
		[Address(RVA = "0x2028570", Offset = "0x2028671", VA = "0x2028570")]
		public void SetTimeParamTable(TimeParamTable[] timeParamTables)
		{
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B67")]
		[Address(RVA = "0x202AD20", Offset = "0x202AE21", VA = "0x202AD20")]
		public MaterialChangeTime()
		{
		}

		// Token: 0x040180D8 RID: 98520
		[Token(Token = "0x4014BB5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TimeParamTable[] _TimeParamTables;

		// Token: 0x040180D9 RID: 98521
		[Token(Token = "0x4014BB6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Material[] Materials;

		// Token: 0x040180DA RID: 98522
		[Token(Token = "0x4014BB7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RendererMaterial[] _RendererMaterials;

		// Token: 0x040180DB RID: 98523
		[Token(Token = "0x4014BB8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Light _Light;
	}
}

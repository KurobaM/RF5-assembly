using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200110E RID: 4366
	[Token(Token = "0x2000AFD")]
	public class RendererChangeTime : MonoBehaviour
	{
		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E6F RID: 28271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF9")]
		public TimeParamTable TimeParamTable
		{
			[Token(Token = "0x6005B98")]
			[Address(RVA = "0x202F130", Offset = "0x202F231", VA = "0x202F130")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B99")]
			[Address(RVA = "0x202F140", Offset = "0x202F241", VA = "0x202F140")]
			set
			{
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06006E70 RID: 28272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E71 RID: 28273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFA")]
		[SerializeField]
		public RendererMaterial[] RendererMaterials
		{
			[Token(Token = "0x6005B9A")]
			[Address(RVA = "0x202F150", Offset = "0x202F251", VA = "0x202F150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B9B")]
			[Address(RVA = "0x202F160", Offset = "0x202F261", VA = "0x202F160")]
			set
			{
			}
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0x202F170", Offset = "0x202F271", VA = "0x202F170")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0x202F260", Offset = "0x202F361", VA = "0x202F260")]
		private void Start()
		{
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0x202D700", Offset = "0x202D801", VA = "0x202D700")]
		public void UpdateRendererParameter(int value)
		{
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9F")]
		[Address(RVA = "0x202F410", Offset = "0x202F511", VA = "0x202F410")]
		public RendererChangeTime()
		{
		}

		// Token: 0x04018106 RID: 98566
		[Token(Token = "0x4014BCF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TimeParamTable _TimeParamTable;

		// Token: 0x04018107 RID: 98567
		[Token(Token = "0x4014BD0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Material[] Materials;

		// Token: 0x04018108 RID: 98568
		[Token(Token = "0x4014BD1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RendererMaterial[] _RendererMaterials;

		// Token: 0x04018109 RID: 98569
		[Token(Token = "0x4014BD2")]
		[FieldOffset(Offset = "0x30")]
		private int NowMaterialIndex;
	}
}

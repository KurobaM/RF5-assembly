using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E10 RID: 3600
	[Token(Token = "0x2000936")]
	public abstract class BaseSpriteInstancedRenderer : MonoBehaviour
	{
		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06005D8C RID: 23948 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		// (set) Token: 0x06005D8D RID: 23949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AE")]
		public int maxSprites
		{
			[Token(Token = "0x6004DA3")]
			[Address(RVA = "0x23D3790", Offset = "0x23D3891", VA = "0x23D3790")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABDA0", Offset = "0x1ABEA1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004DA4")]
			[Address(RVA = "0x23D37A0", Offset = "0x23D38A1", VA = "0x23D37A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABDB0", Offset = "0x1ABEB1")]
			protected set
			{
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06005D8E RID: 23950 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005D8F RID: 23951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AF")]
		protected Camera m_ViewerCamera
		{
			[Token(Token = "0x6004DA5")]
			[Address(RVA = "0x23D37B0", Offset = "0x23D38B1", VA = "0x23D37B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABDC0", Offset = "0x1ABEC1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DA6")]
			[Address(RVA = "0x23D37C0", Offset = "0x23D38C1", VA = "0x23D37C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABDD0", Offset = "0x1ABED1")]
			set
			{
			}
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA7")]
		[Address(RVA = "0x23D37D0", Offset = "0x23D38D1", VA = "0x23D37D0")]
		private void Start()
		{
		}

		// Token: 0x06005D91 RID: 23953
		[Token(Token = "0x6004DA8")]
		protected abstract Bounds CalculateMeshBounds();

		// Token: 0x06005D92 RID: 23954
		[Token(Token = "0x6004DA9")]
		protected abstract BaseSpriteItemData CreateSpriteItemData();

		// Token: 0x06005D93 RID: 23955
		[Token(Token = "0x6004DAA")]
		protected abstract bool IsRenderingEnabled();

		// Token: 0x06005D94 RID: 23956
		[Token(Token = "0x6004DAB")]
		protected abstract int GetNextSpawnCount();

		// Token: 0x06005D95 RID: 23957
		[Token(Token = "0x6004DAC")]
		protected abstract void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale);

		// Token: 0x06005D96 RID: 23958
		[Token(Token = "0x6004DAD")]
		protected abstract void ConfigureSpriteItemData(BaseSpriteItemData data);

		// Token: 0x06005D97 RID: 23959
		[Token(Token = "0x6004DAE")]
		protected abstract void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data);

		// Token: 0x06005D98 RID: 23960
		[Token(Token = "0x6004DAF")]
		protected abstract void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock);

		// Token: 0x06005D99 RID: 23961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB0")]
		[Address(RVA = "0x23D3880", Offset = "0x23D3981", VA = "0x23D3880")]
		private BaseSpriteItemData DequeueNextSpriteItemData()
		{
			return null;
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x23D3930", Offset = "0x23D3A31", VA = "0x23D3930")]
		private void ReturnSpriteItemData(BaseSpriteItemData splash)
		{
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB2")]
		[Address(RVA = "0x23D39F0", Offset = "0x23D3AF1", VA = "0x23D39F0", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0x23D3A60", Offset = "0x23D3B61", VA = "0x23D3A60")]
		private void GenerateNewSprites()
		{
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x23D3CF0", Offset = "0x23D3DF1", VA = "0x23D3CF0")]
		private void AdvanceAllSprites()
		{
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x23D3E80", Offset = "0x23D3F81", VA = "0x23D3E80")]
		private void RenderAllSprites()
		{
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x23D46C0", Offset = "0x23D47C1", VA = "0x23D46C0", Slot = "13")]
		protected virtual Mesh GenerateMesh()
		{
			return null;
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x23D4A70", Offset = "0x23D4B71", VA = "0x23D4A70")]
		protected BaseSpriteInstancedRenderer()
		{
		}

		// Token: 0x0400BDA9 RID: 48553
		[Token(Token = "0x4008E12")]
		public const int kArrayMaxSprites = 1000;

		// Token: 0x0400BDAA RID: 48554
		[Token(Token = "0x4008E13")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17E420", Offset = "0x17E521")]
		private int <maxSprites>k__BackingField;

		// Token: 0x0400BDAB RID: 48555
		[Token(Token = "0x4008E14")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E430", Offset = "0x17E531")]
		public Mesh modelMesh;

		// Token: 0x0400BDAC RID: 48556
		[Token(Token = "0x4008E15")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E470", Offset = "0x17E571")]
		public Material renderMaterial;

		// Token: 0x0400BDAD RID: 48557
		[Token(Token = "0x4008E16")]
		[FieldOffset(Offset = "0x30")]
		protected Queue<BaseSpriteItemData> m_Available;

		// Token: 0x0400BDAE RID: 48558
		[Token(Token = "0x4008E17")]
		[FieldOffset(Offset = "0x38")]
		protected HashSet<BaseSpriteItemData> m_Active;

		// Token: 0x0400BDAF RID: 48559
		[Token(Token = "0x4008E18")]
		[FieldOffset(Offset = "0x40")]
		private MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x0400BDB0 RID: 48560
		[Token(Token = "0x4008E19")]
		[FieldOffset(Offset = "0x48")]
		private Matrix4x4[] m_ModelMatrices;

		// Token: 0x0400BDB1 RID: 48561
		[Token(Token = "0x4008E1A")]
		[FieldOffset(Offset = "0x50")]
		private float[] m_StartTimes;

		// Token: 0x0400BDB2 RID: 48562
		[Token(Token = "0x4008E1B")]
		[FieldOffset(Offset = "0x58")]
		private float[] m_EndTimes;

		// Token: 0x0400BDB3 RID: 48563
		[Token(Token = "0x4008E1C")]
		[FieldOffset(Offset = "0x60")]
		protected SpriteSheetData m_SpriteSheetLayout;

		// Token: 0x0400BDB4 RID: 48564
		[Token(Token = "0x4008E1D")]
		[FieldOffset(Offset = "0x68")]
		protected Texture m_SpriteTexture;

		// Token: 0x0400BDB5 RID: 48565
		[Token(Token = "0x4008E1E")]
		[FieldOffset(Offset = "0x70")]
		protected Color m_TintColor;

		// Token: 0x0400BDB6 RID: 48566
		[Token(Token = "0x4008E1F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17E4B0", Offset = "0x17E5B1")]
		private Camera <m_ViewerCamera>k__BackingField;
	}
}

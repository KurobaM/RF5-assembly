using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x20007EC")]
	public class CSVBuilder
	{
		// Token: 0x06004E6C RID: 20076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004147")]
		[Address(RVA = "0x2125AC0", Offset = "0x2125BC1", VA = "0x2125AC0")]
		public CSVBuilder(char newSeparatorCharacter = ',')
		{
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004148")]
		[Address(RVA = "0x2125B60", Offset = "0x2125C61", VA = "0x2125B60")]
		public void Append(string item)
		{
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004149")]
		[Address(RVA = "0x2125CA0", Offset = "0x2125DA1", VA = "0x2125CA0")]
		public void Append(GameObject gameObject)
		{
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x2125E00", Offset = "0x2125F01", VA = "0x2125E00")]
		public void Append(object item)
		{
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x21268C0", Offset = "0x21269C1", VA = "0x21268C0")]
		public void Append(Vector3 vector)
		{
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x2126000", Offset = "0x2126101", VA = "0x2126000")]
		public void Append(Transform transform)
		{
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x2126980", Offset = "0x2126A81", VA = "0x2126980")]
		public void Append(IEnumerable<string> list)
		{
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414E")]
		[Address(RVA = "0x2126BF0", Offset = "0x2126CF1", VA = "0x2126BF0")]
		public void AppendLine()
		{
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600414F")]
		[Address(RVA = "0x2126C60", Offset = "0x2126D61", VA = "0x2126C60")]
		public void AppendLine(string item)
		{
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004150")]
		[Address(RVA = "0x2126CD0", Offset = "0x2126DD1", VA = "0x2126CD0")]
		public void AppendLine(IEnumerable<string> list)
		{
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004151")]
		[Address(RVA = "0x2126D40", Offset = "0x2126E41", VA = "0x2126D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004152")]
		[Address(RVA = "0x2126160", Offset = "0x2126261", VA = "0x2126160")]
		private void InternalAppend(Type itemType, object item)
		{
		}

		// Token: 0x0400AFAB RID: 44971
		[Token(Token = "0x400842A")]
		[FieldOffset(Offset = "0x10")]
		private StringBuilder builder;

		// Token: 0x0400AFAC RID: 44972
		[Token(Token = "0x400842B")]
		[FieldOffset(Offset = "0x18")]
		private char separatorCharacter;

		// Token: 0x0400AFAD RID: 44973
		[Token(Token = "0x400842C")]
		[FieldOffset(Offset = "0x20")]
		private string currentSeparator;
	}
}

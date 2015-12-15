﻿using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp.Responses.ExtendedReplies
{
    internal abstract class ExtendedReplyInfo : SshData
    {
        protected override void LoadData()
        {
            //  Read Message Type
            var messageType = this.ReadByte();

            //  Read Response ID
            var responseId = this.ReadUInt32();
        }

        protected override void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}

﻿using HotChocolate.Types;
using RorschachModern.Database.Models;

namespace RorschachModern.GraphQL.Entities
{
    public class ResponseType : ObjectType<Response>
    {
        protected override void Configure(IObjectTypeDescriptor<Response> descriptor)
        {
            base.Configure(descriptor);


            descriptor.Field(x => x.ID).Name("id").Type<IdType>();
            descriptor.Field(x => x.ParticipantID).Name("participantId").Ignore();
            descriptor.Field(x => x.QuestionID).Name("questionId").Ignore();
            descriptor.Field(x => x.Text).Name("text").Type<StringType>();
            descriptor.Field(x => x.Participant).Name("participant").Type<ParticipantType>();
            descriptor.Field(x => x.Question).Name("question").Type<QuestionType>();
        }
    }
}
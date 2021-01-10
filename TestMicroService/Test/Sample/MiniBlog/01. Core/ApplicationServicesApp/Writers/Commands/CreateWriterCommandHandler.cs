using ApplicationServices.Commands;
using CoreDomain.ValueObjects;
using CoreDomainApp.Writer.Entities;
using CoreDomainApp.Writer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitie;

namespace ApplicationServicesApp.Writers.Commands
{
    public class CreateWriterCommandHandler : CommandHandler<CreateWiterCommand, long>
    {
        private readonly IWriterRepository _writerRepository;

        public CreateWriterCommandHandler(ZaminServices zaminServices, IWriterRepository writerRepository) : base(zaminServices)
        {
            this._writerRepository = writerRepository;
        }
        public override Task<CommandResult<long>> Handle(CreateWiterCommand request)
        {
            Writer writer = new Writer(BusinessId.FromGuid(request.BusinessId), request.FirstName, request.LastName);
            _writerRepository.Insert(writer);
            _writerRepository.Commit();
            return OkAsync(writer.Id);
        }
    }
}

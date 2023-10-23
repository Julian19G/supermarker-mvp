using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSelectedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildSource(providersBindingSource);

            loadAllOpenProvidersList();

            this.view.Show();
        }

        private void loadAllOpenProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            var providers = new ProvidersModel();
            providers.IdProvider = Convert.ToInt32(view.ProvidersId);
            providers.NameProvider = view.ProvidersName;
            providers.ObservationProvider = view.ProvidersObservation;

            try
            {
                new Common.ModelDataValidation().Validate(providers);
                if (view.IsEdit)
                {
                    repository.Edit(providers);
                    view.Message = "Provider Edited Succesfuly";
                }
                else
                {
                    repository.Add(providers);
                    view.Message = "Provider Added successfuly";
                }
                view.IsSuccesfull = true;
                loadAllOpenProvidersList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesfull = false;
                view.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            view.ProvidersId = "0";
            view.ProvidersName = "";
            view.ProvidersObservation = "";
        }

        private void DeleteSelectedProviders(object? sender, EventArgs e)
        {
            try
            {
                var providers = (ProvidersModel)providersBindingSource.Current;

                repository.Delete(providers.IdProvider);
                view.IsSuccesfull = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllOpenProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccesfull = false;
                view.Message = "An Error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            var providers = (ProvidersModel)providersBindingSource.Current;

            view.ProvidersId = providers.IdProvider.ToString();
            view.ProvidersName = providers.NameProvider;
            view.ProvidersObservation = providers.ObservationProvider;


            view.IsEdit = true;
        }

        private void AddNewProviders(object? sender, EventArgs e)
        {
        view.IsEdit = false;
        }

        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }
    }
}

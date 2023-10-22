using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp1.Views;
using Supermarket_mvp1.Models;
using Supermarket_mvp1._Repositories;

namespace Supermarket_mvp1.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();

        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }
                
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            //Se crea un objeto de la clase PayModeModel y se asigna los datos de las caja de texto de la vista
            var payMode = new PayModeModel();
            payMode.Id = Convert .ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().Validate(payMode);
                if(view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited successfuly";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode added successfuly";
                }
                view.IsSuccessful = true;
                loadAllPayModeList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                //Si ocurre una excepcion se confiigura el IsSuccessfull en flase  y la propiedad Message de 
                // de la vista se asigna el mensaje de la excepcion 
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                //Se recupera el objeto de la fila seleccionada del dataviewgrid
                var payMode = (PayModeModel)payModeBindingSource.Current;

                //Se invoca el mertodo Delete del repositorio pasandole el ID del Pay Mode
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllPayModeList();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            //Se obtiene el objeto de datadridview que se encuentra seleccionado 
            var payMode = (PayModeModel)payModeBindingSource.Current;

            //Se cambia el contenido de las cajas de texto por el objeto recuperado del datadridview
            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            // Se establece el modo como edicion
            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            //MessageBox.Show("Hizo Clic en el boton nuevo");
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }

        private void View_CancelEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}

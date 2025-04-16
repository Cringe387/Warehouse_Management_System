using Warehouse_Management_System.Domain.Contracts;
using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.Interfaces;
using Warehouse_Management_System.Domain.DTO;

namespace Warehouse_Management_System.Domain.ContractsRealization
{
    public class AuthenticationService(IRepository _repository) : IAuthenticationService
    {
        public async Task<StorageManager> RegisterStorageManagerAsync(StorageManagerDTO newstorageManager)
        {
            if (await IsStorageManagerExistsAsync(newstorageManager))
                return null;

            var registeredStorageManager = await _repository.AddStorageManagerAsync(ConvertToStorageManager(newstorageManager));
            return registeredStorageManager;
        }

        public async Task<StorageManager> LoginStorageManagerAsync(string login, string password)
        {
            var storageManager = await _repository.GetStorageManagerByLoginAsync(login);

            if (storageManager == null)
                return null;

            if (!storageManager.IsValidPassword(password))
                return null;

            return storageManager;
        }

        public async Task<StorageManager> ChangeStorageManagerPasswordAsync(StorageManagerDTO updatedStorageManager)
        {
            var storageManager = await _repository.GetStorageManagerByLoginAsync(updatedStorageManager.Login);

            if (storageManager == null)
                return null;

            storageManager.Password = updatedStorageManager.Password;

            await _repository.UpdateStorageManagerAsync(storageManager);

            return storageManager;
        }

        public async Task<StorageLogist> RegisterStorageLogistAsync(StorageLogistDTO newStorageLogist)
        {
            if (await IsStorageLogistExistsAsync(newStorageLogist))
                return null;

            var registeredStorageLogist = await _repository.AddStorageLogistAsync(ConvertToStorageLogist(newStorageLogist));
            return registeredStorageLogist;
        }

        public async Task<StorageLogist> LoginStorageLogistAsync(string login, string password)
        {
            var storageLogist = await _repository.GetStorageLogistByLoginAsync(login);

            if (storageLogist == null)
                return null;

            if (!storageLogist.IsValidPassword(password))
                return null;

            return storageLogist;
        }

        public async Task<StorageLogist> ChangeStorageLogistPasswordAsync(StorageLogistDTO updatedStorageLogist)
        {
            var storageLogist = await _repository.GetStorageLogistByLoginAsync(updatedStorageLogist.Login);

            if (storageLogist == null)
                return null;

            storageLogist.Password = updatedStorageLogist.Password;

            await _repository.UpdateStorageLogistAsync(storageLogist);

            return storageLogist;
        }

        private async Task<bool> IsStorageManagerExistsAsync(StorageManagerDTO storageManagerDto)
        {
            var StorageManagerByLogin = await _repository.GetStorageManagerByLoginAsync(storageManagerDto.Login);

            if (StorageManagerByLogin == null)
                return false;
            return true;
        }

        private StorageManager ConvertToStorageManager(StorageManagerDTO storageManagerDto)
        {
            return new StorageManager
            {
                Login = storageManagerDto.Login,
                Password = storageManagerDto.Password,
                Name = storageManagerDto.Name
            };
        }

        private async Task<bool> IsStorageLogistExistsAsync(StorageLogistDTO storageLogistDto)
        {
            var storageLogistByLogin = await _repository.GetStorageLogistByLoginAsync(storageLogistDto.Login);

            if (storageLogistByLogin == null)
                return false;
            return true;
        }

        private StorageLogist ConvertToStorageLogist(StorageLogistDTO storageLogistDto)
        {
            return new StorageLogist
            {
                Name = storageLogistDto.Name,
                Login = storageLogistDto.Login,
                Password = storageLogistDto.Password
            };
        }
    }
}
